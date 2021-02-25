namespace pointofsale.controlform
{
    partial class FormBarang
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
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox_data = new System.Windows.Forms.GroupBox();
            this.textBox_cari = new System.Windows.Forms.TextBox();
            this.dataGridView_barang = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox_proses = new System.Windows.Forms.GroupBox();
            this.button_hapus = new System.Windows.Forms.Button();
            this.button_simpan = new System.Windows.Forms.Button();
            this.button_ubah = new System.Windows.Forms.Button();
            this.button_baru = new System.Windows.Forms.Button();
            this.groupBox_form = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.button_cariproduk = new System.Windows.Forms.Button();
            this.textBox_stok = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_hargabeli = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_satuan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_namabarang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_idproduk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_idbarang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_barang)).BeginInit();
            this.groupBox_proses.SuspendLayout();
            this.groupBox_form.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Data Barang";
            // 
            // groupBox_data
            // 
            this.groupBox_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_data.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox_data.Controls.Add(this.textBox_cari);
            this.groupBox_data.Controls.Add(this.dataGridView_barang);
            this.groupBox_data.Controls.Add(this.label8);
            this.groupBox_data.Location = new System.Drawing.Point(447, 65);
            this.groupBox_data.Name = "groupBox_data";
            this.groupBox_data.Size = new System.Drawing.Size(441, 456);
            this.groupBox_data.TabIndex = 6;
            this.groupBox_data.TabStop = false;
            this.groupBox_data.Text = ":: Data Barang ::";
            // 
            // textBox_cari
            // 
            this.textBox_cari.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_cari.Location = new System.Drawing.Point(217, 36);
            this.textBox_cari.Name = "textBox_cari";
            this.textBox_cari.Size = new System.Drawing.Size(194, 27);
            this.textBox_cari.TabIndex = 15;
            this.textBox_cari.TextChanged += new System.EventHandler(this.textBox_cari_TextChanged);
            // 
            // dataGridView_barang
            // 
            this.dataGridView_barang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_barang.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView_barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_barang.Location = new System.Drawing.Point(15, 98);
            this.dataGridView_barang.Name = "dataGridView_barang";
            this.dataGridView_barang.Size = new System.Drawing.Size(409, 340);
            this.dataGridView_barang.TabIndex = 0;
            this.dataGridView_barang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_barang_CellClick);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cari Barang (ID/nama)";
            // 
            // groupBox_proses
            // 
            this.groupBox_proses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_proses.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox_proses.Controls.Add(this.button_hapus);
            this.groupBox_proses.Controls.Add(this.button_simpan);
            this.groupBox_proses.Controls.Add(this.button_ubah);
            this.groupBox_proses.Controls.Add(this.button_baru);
            this.groupBox_proses.Location = new System.Drawing.Point(12, 395);
            this.groupBox_proses.Name = "groupBox_proses";
            this.groupBox_proses.Size = new System.Drawing.Size(421, 126);
            this.groupBox_proses.TabIndex = 5;
            this.groupBox_proses.TabStop = false;
            this.groupBox_proses.Text = ":: Proses ::";
            // 
            // button_hapus
            // 
            this.button_hapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_hapus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hapus.Location = new System.Drawing.Point(234, 70);
            this.button_hapus.Name = "button_hapus";
            this.button_hapus.Size = new System.Drawing.Size(160, 36);
            this.button_hapus.TabIndex = 3;
            this.button_hapus.Text = "Hapus";
            this.button_hapus.UseVisualStyleBackColor = true;
            this.button_hapus.Click += new System.EventHandler(this.button_hapus_Click);
            // 
            // button_simpan
            // 
            this.button_simpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_simpan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_simpan.Location = new System.Drawing.Point(234, 28);
            this.button_simpan.Name = "button_simpan";
            this.button_simpan.Size = new System.Drawing.Size(160, 36);
            this.button_simpan.TabIndex = 2;
            this.button_simpan.Text = "Simpan";
            this.button_simpan.UseVisualStyleBackColor = true;
            this.button_simpan.Click += new System.EventHandler(this.button_simpan_Click);
            // 
            // button_ubah
            // 
            this.button_ubah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_ubah.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ubah.Location = new System.Drawing.Point(39, 72);
            this.button_ubah.Name = "button_ubah";
            this.button_ubah.Size = new System.Drawing.Size(163, 36);
            this.button_ubah.TabIndex = 1;
            this.button_ubah.Text = "Ubah";
            this.button_ubah.UseVisualStyleBackColor = true;
            this.button_ubah.Click += new System.EventHandler(this.button_ubah_Click);
            // 
            // button_baru
            // 
            this.button_baru.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_baru.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_baru.Location = new System.Drawing.Point(39, 30);
            this.button_baru.Name = "button_baru";
            this.button_baru.Size = new System.Drawing.Size(163, 36);
            this.button_baru.TabIndex = 0;
            this.button_baru.Text = "Baru";
            this.button_baru.UseVisualStyleBackColor = true;
            this.button_baru.Click += new System.EventHandler(this.button_baru_Click);
            // 
            // groupBox_form
            // 
            this.groupBox_form.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_form.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox_form.Controls.Add(this.linkLabel2);
            this.groupBox_form.Controls.Add(this.label12);
            this.groupBox_form.Controls.Add(this.button_cariproduk);
            this.groupBox_form.Controls.Add(this.textBox_stok);
            this.groupBox_form.Controls.Add(this.label7);
            this.groupBox_form.Controls.Add(this.textBox_hargabeli);
            this.groupBox_form.Controls.Add(this.label6);
            this.groupBox_form.Controls.Add(this.comboBox_satuan);
            this.groupBox_form.Controls.Add(this.label4);
            this.groupBox_form.Controls.Add(this.textBox_namabarang);
            this.groupBox_form.Controls.Add(this.label3);
            this.groupBox_form.Controls.Add(this.textBox_idproduk);
            this.groupBox_form.Controls.Add(this.label2);
            this.groupBox_form.Controls.Add(this.textBox_idbarang);
            this.groupBox_form.Controls.Add(this.label1);
            this.groupBox_form.Location = new System.Drawing.Point(12, 65);
            this.groupBox_form.Name = "groupBox_form";
            this.groupBox_form.Size = new System.Drawing.Size(421, 324);
            this.groupBox_form.TabIndex = 4;
            this.groupBox_form.TabStop = false;
            this.groupBox_form.Text = ":: Form Barang ::";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(223, 98);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(70, 21);
            this.linkLabel2.TabIndex = 21;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "KlikDisini";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(43, 98);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(206, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "**produk belum terdaftar?";
            // 
            // button_cariproduk
            // 
            this.button_cariproduk.Location = new System.Drawing.Point(342, 62);
            this.button_cariproduk.Name = "button_cariproduk";
            this.button_cariproduk.Size = new System.Drawing.Size(57, 29);
            this.button_cariproduk.TabIndex = 19;
            this.button_cariproduk.Text = "Cari";
            this.button_cariproduk.UseVisualStyleBackColor = true;
            this.button_cariproduk.Click += new System.EventHandler(this.button_cariproduk_Click);
            // 
            // textBox_stok
            // 
            this.textBox_stok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_stok.Location = new System.Drawing.Point(202, 247);
            this.textBox_stok.Name = "textBox_stok";
            this.textBox_stok.Size = new System.Drawing.Size(93, 27);
            this.textBox_stok.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Stok";
            // 
            // textBox_hargabeli
            // 
            this.textBox_hargabeli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_hargabeli.Location = new System.Drawing.Point(202, 212);
            this.textBox_hargabeli.Name = "textBox_hargabeli";
            this.textBox_hargabeli.Size = new System.Drawing.Size(192, 27);
            this.textBox_hargabeli.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Harga Beli";
            // 
            // comboBox_satuan
            // 
            this.comboBox_satuan.FormattingEnabled = true;
            this.comboBox_satuan.Items.AddRange(new object[] {
            "Liter",
            "Kg",
            "Pack",
            "Box",
            "Lusin",
            "Kodi"});
            this.comboBox_satuan.Location = new System.Drawing.Point(202, 177);
            this.comboBox_satuan.Name = "comboBox_satuan";
            this.comboBox_satuan.Size = new System.Drawing.Size(192, 29);
            this.comboBox_satuan.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Satuan";
            // 
            // textBox_namabarang
            // 
            this.textBox_namabarang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_namabarang.Location = new System.Drawing.Point(202, 142);
            this.textBox_namabarang.Name = "textBox_namabarang";
            this.textBox_namabarang.Size = new System.Drawing.Size(192, 27);
            this.textBox_namabarang.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nama Barang";
            // 
            // textBox_idproduk
            // 
            this.textBox_idproduk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_idproduk.Location = new System.Drawing.Point(202, 63);
            this.textBox_idproduk.Name = "textBox_idproduk";
            this.textBox_idproduk.Size = new System.Drawing.Size(144, 27);
            this.textBox_idproduk.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Produk";
            // 
            // textBox_idbarang
            // 
            this.textBox_idbarang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_idbarang.Location = new System.Drawing.Point(202, 28);
            this.textBox_idbarang.Name = "textBox_idbarang";
            this.textBox_idbarang.Size = new System.Drawing.Size(192, 27);
            this.textBox_idbarang.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Barang";
            // 
            // FormBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 538);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox_data);
            this.Controls.Add(this.groupBox_proses);
            this.Controls.Add(this.groupBox_form);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormBarang";
            this.Text = "FormBarang";
            this.groupBox_data.ResumeLayout(false);
            this.groupBox_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_barang)).EndInit();
            this.groupBox_proses.ResumeLayout(false);
            this.groupBox_form.ResumeLayout(false);
            this.groupBox_form.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox_data;
        private System.Windows.Forms.TextBox textBox_cari;
        private System.Windows.Forms.DataGridView dataGridView_barang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox_proses;
        private System.Windows.Forms.Button button_hapus;
        private System.Windows.Forms.Button button_simpan;
        private System.Windows.Forms.Button button_ubah;
        private System.Windows.Forms.Button button_baru;
        private System.Windows.Forms.GroupBox groupBox_form;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_cariproduk;
        private System.Windows.Forms.TextBox textBox_stok;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_hargabeli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_satuan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_namabarang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_idproduk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_idbarang;
        private System.Windows.Forms.Label label1;
    }
}