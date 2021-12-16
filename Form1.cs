using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientReservasi_20190140015
{
    public partial class Form1 : Form
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
        public Form1()
        {
            InitializeComponent();

            TampilData();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string idPemesanan = IDReservasi.Text;
            string namaCust = Nama.Text;
            string noTelp = NoTelepon.Text;
            int jmlPemesanan = int.Parse(JumlahPemesanan.Text);
            string idLokasi = IDLokasi.Text;

            var a = service.pemesanan(idPemesanan,namaCust,noTelp,jmlPemesanan,idLokasi);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string idPemesanan = IDReservasi.Text;
            string namaCust = Nama.Text;
            string noTelp = NoTelepon.Text;

            var a = service.editPemesanan(idPemesanan, namaCust,noTelp);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        public void TampilData()
        {
            var list = service.Pemesanan1();
            dataPemesanan.DataSource = list;
        }

        public void Clear()
        {
            IDReservasi.Clear();
            Nama.Clear();
            NoTelepon.Clear();
            IDLokasi.Clear();
            JumlahPemesanan.Clear();

            JumlahPemesanan.Enabled = true;
            IDLokasi.Enabled = true;

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            IDReservasi.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dataPemesanan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDReservasi.Text = Convert.ToString(dataPemesanan.Rows[e.RowIndex].Cells["idPemesanan"].Value);
            Nama.Text = Convert.ToString(dataPemesanan.Rows[e.RowIndex].Cells["namaCustomer"].Value);
            NoTelepon.Text = Convert.ToString(dataPemesanan.Rows[e.RowIndex].Cells["noTelepon"].Value);
            JumlahPemesanan.Text = Convert.ToString(dataPemesanan.Rows[e.RowIndex].Cells["jumlahPemesanan"].Value);
            IDLokasi.Text = Convert.ToString(dataPemesanan.Rows[e.RowIndex].Cells["Lokasi"].Value);

            JumlahPemesanan.Enabled = false;
            IDLokasi.Enabled = false;

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

            btnSave.Enabled = false;
            IDReservasi.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string idPemesanan = IDReservasi.Text;

            var a = service.deletePemesanan(idPemesanan);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }
    }
}
