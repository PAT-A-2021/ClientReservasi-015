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
    public partial class Register : Form
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
        public Register()
        {
            InitializeComponent();
            TampilData();
            txID.Visible = false;
            btUpdate.Enabled = false;
            btHapus.Enabled = false;
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            string username = txUser.Text;
            string password = txPass.Text;
            string kategori = cbKategori.Text;
            string a = service.Register(username, password, kategori);

            if(txUser.Text == "" || txPass.Text == "" || cbKategori.Text == "")
            {
                MessageBox.Show("Semua data wajib diisi.");
            }
            else
            {
                MessageBox.Show(a);
                Refresh();
                TampilData();
            }
        }

        private void TampilData()
        {
            var list = service.dataRegist();
            dtRegister.DataSource = list;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            string username = txUser.Text;
            string password = txPass.Text;
            string kategori = cbKategori.Text;
            int id = Int32.Parse(txID.Text);
            string a = service.updateRegister(username,password,kategori,id);

            if(txUser.Text == "" || txPass.Text == "" || cbKategori.Text == "")
            {
                MessageBox.Show("Semua data wajib diisi.");
            }
            else
            {
                MessageBox.Show(a);
                Clear();
                TampilData();
            }
        }

        private void Clear()
        {
            txUser.Clear();
            txPass.Clear();
            cbKategori.SelectedItem = null;

            btSimpan.Enabled = true;
            btUpdate.Enabled = false;
            btHapus.Enabled = false;
        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            string username = txUser.Text;

            DialogResult dr = MessageBox.Show("Apakah anda yakin ingin menghapus data ini ?", "Hapus Data", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                string a = service.deleteRegister(username);
                MessageBox.Show(a);
                Clear();
                TampilData();
            }
            else if(dr == DialogResult.No)
            {

            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dtRegister_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txID.Text = Convert.ToString(dtRegister.Rows[e.RowIndex].Cells[0].Value);
            txUser.Text = Convert.ToString(dtRegister.Rows[e.RowIndex].Cells[1].Value);
            txPass.Text = Convert.ToString(dtRegister.Rows[e.RowIndex].Cells[2].Value);
            cbKategori.Text = Convert.ToString(dtRegister.Rows[e.RowIndex].Cells[3].Value);

            btUpdate.Enabled = true;
            btHapus.Enabled = true;

            btSimpan.Enabled = false;
        }
    }
}
