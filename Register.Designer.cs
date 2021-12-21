namespace ClientReservasi_20190140015
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.txUser = new System.Windows.Forms.TextBox();
            this.txPass = new System.Windows.Forms.TextBox();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.labelKategori = new System.Windows.Forms.Label();
            this.dtRegister = new System.Windows.Forms.DataGridView();
            this.btSimpan = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btHapus = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.txID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(40, 42);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(55, 13);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "Username";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(40, 114);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(53, 13);
            this.labelPass.TabIndex = 1;
            this.labelPass.Text = "Password";
            // 
            // txUser
            // 
            this.txUser.Location = new System.Drawing.Point(156, 39);
            this.txUser.Name = "txUser";
            this.txUser.Size = new System.Drawing.Size(218, 20);
            this.txUser.TabIndex = 2;
            // 
            // txPass
            // 
            this.txPass.Location = new System.Drawing.Point(156, 111);
            this.txPass.Name = "txPass";
            this.txPass.PasswordChar = '*';
            this.txPass.Size = new System.Drawing.Size(218, 20);
            this.txPass.TabIndex = 3;
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(156, 182);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(218, 21);
            this.cbKategori.TabIndex = 4;
            // 
            // labelKategori
            // 
            this.labelKategori.AutoSize = true;
            this.labelKategori.Location = new System.Drawing.Point(42, 185);
            this.labelKategori.Name = "labelKategori";
            this.labelKategori.Size = new System.Drawing.Size(46, 13);
            this.labelKategori.TabIndex = 5;
            this.labelKategori.Text = "Kategori";
            // 
            // dtRegister
            // 
            this.dtRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtRegister.Location = new System.Drawing.Point(12, 234);
            this.dtRegister.Name = "dtRegister";
            this.dtRegister.Size = new System.Drawing.Size(776, 204);
            this.dtRegister.TabIndex = 6;
            this.dtRegister.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtRegister_CellClick);
            // 
            // btSimpan
            // 
            this.btSimpan.Location = new System.Drawing.Point(636, 55);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(75, 23);
            this.btSimpan.TabIndex = 7;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseVisualStyleBackColor = true;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(636, 93);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 8;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btHapus
            // 
            this.btHapus.Location = new System.Drawing.Point(636, 132);
            this.btHapus.Name = "btHapus";
            this.btHapus.Size = new System.Drawing.Size(75, 23);
            this.btHapus.TabIndex = 9;
            this.btHapus.Text = "Hapus";
            this.btHapus.UseVisualStyleBackColor = true;
            this.btHapus.Click += new System.EventHandler(this.btHapus_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(636, 175);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 10;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // txID
            // 
            this.txID.Location = new System.Drawing.Point(671, 12);
            this.txID.Name = "txID";
            this.txID.Size = new System.Drawing.Size(100, 20);
            this.txID.TabIndex = 11;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txID);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btHapus);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.dtRegister);
            this.Controls.Add(this.labelKategori);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.txPass);
            this.Controls.Add(this.txUser);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelUser);
            this.Name = "Register";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.dtRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox txUser;
        private System.Windows.Forms.TextBox txPass;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.Label labelKategori;
        private System.Windows.Forms.DataGridView dtRegister;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btHapus;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.TextBox txID;
    }
}