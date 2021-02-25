namespace pointofsale.controlform
{
    partial class UC_FormTransaksiPenjualan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_namauser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_cariuser = new System.Windows.Forms.Button();
            this.dateTimePicker_kwitansi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_iduser = new System.Windows.Forms.TextBox();
            this.textBox_nokwitansi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_transaksijual = new System.Windows.Forms.GroupBox();
            this.dataGridView_transaksijual = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_plus = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_mines = new System.Windows.Forms.Button();
            this.textBox_qty = new System.Windows.Forms.TextBox();
            this.button_scandiskon = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_diskon = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button_caribrg = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_harga = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_namabrg = new System.Windows.Forms.TextBox();
            this.textBox_kodebarang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_simpan = new System.Windows.Forms.Button();
            this.button_baru = new System.Windows.Forms.Button();
            this.textBox_kembali = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_bayar = new System.Windows.Forms.TextBox();
            this.label_totalseluruh = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox_transaksijual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_transaksijual)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaksi Penjualan";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.textBox_namauser);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button_cariuser);
            this.groupBox1.Controls.Add(this.dateTimePicker_kwitansi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_iduser);
            this.groupBox1.Controls.Add(this.textBox_nokwitansi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(31, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proses Transaksi";
            // 
            // textBox_namauser
            // 
            this.textBox_namauser.Location = new System.Drawing.Point(227, 135);
            this.textBox_namauser.Name = "textBox_namauser";
            this.textBox_namauser.Size = new System.Drawing.Size(170, 27);
            this.textBox_namauser.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nama Pegawai";
            // 
            // button_cariuser
            // 
            this.button_cariuser.Location = new System.Drawing.Point(154, 134);
            this.button_cariuser.Name = "button_cariuser";
            this.button_cariuser.Size = new System.Drawing.Size(51, 29);
            this.button_cariuser.TabIndex = 16;
            this.button_cariuser.Text = "Cari";
            this.button_cariuser.UseVisualStyleBackColor = true;
            this.button_cariuser.Click += new System.EventHandler(this.button_cariuser_Click);
            // 
            // dateTimePicker_kwitansi
            // 
            this.dateTimePicker_kwitansi.CustomFormat = "";
            this.dateTimePicker_kwitansi.Location = new System.Drawing.Point(289, 70);
            this.dateTimePicker_kwitansi.Name = "dateTimePicker_kwitansi";
            this.dateTimePicker_kwitansi.Size = new System.Drawing.Size(108, 27);
            this.dateTimePicker_kwitansi.TabIndex = 8;
            this.dateTimePicker_kwitansi.Value = new System.DateTime(2018, 5, 2, 21, 14, 21, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tanggal Kwitansi";
            // 
            // textBox_iduser
            // 
            this.textBox_iduser.Location = new System.Drawing.Point(17, 135);
            this.textBox_iduser.Name = "textBox_iduser";
            this.textBox_iduser.Size = new System.Drawing.Size(140, 27);
            this.textBox_iduser.TabIndex = 13;
            // 
            // textBox_nokwitansi
            // 
            this.textBox_nokwitansi.Location = new System.Drawing.Point(289, 25);
            this.textBox_nokwitansi.Name = "textBox_nokwitansi";
            this.textBox_nokwitansi.Size = new System.Drawing.Size(108, 27);
            this.textBox_nokwitansi.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "No Kwitansi";
            // 
            // groupBox_transaksijual
            // 
            this.groupBox_transaksijual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_transaksijual.Controls.Add(this.dataGridView_transaksijual);
            this.groupBox_transaksijual.Location = new System.Drawing.Point(455, 52);
            this.groupBox_transaksijual.Name = "groupBox_transaksijual";
            this.groupBox_transaksijual.Size = new System.Drawing.Size(503, 404);
            this.groupBox_transaksijual.TabIndex = 2;
            this.groupBox_transaksijual.TabStop = false;
            this.groupBox_transaksijual.Text = "Data Transaksi";
            // 
            // dataGridView_transaksijual
            // 
            this.dataGridView_transaksijual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_transaksijual.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView_transaksijual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_transaksijual.Location = new System.Drawing.Point(14, 29);
            this.dataGridView_transaksijual.Name = "dataGridView_transaksijual";
            this.dataGridView_transaksijual.Size = new System.Drawing.Size(475, 359);
            this.dataGridView_transaksijual.TabIndex = 35;
            this.dataGridView_transaksijual.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_transaksijual_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.button_plus);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.button_mines);
            this.groupBox3.Controls.Add(this.textBox_qty);
            this.groupBox3.Controls.Add(this.button_scandiskon);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBox_diskon);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.button_caribrg);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox_harga);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox_namabrg);
            this.groupBox3.Controls.Add(this.textBox_kodebarang);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(31, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(418, 234);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pilih Barang";
            // 
            // button_plus
            // 
            this.button_plus.Location = new System.Drawing.Point(289, 171);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(51, 44);
            this.button_plus.TabIndex = 30;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(10, 27);
            this.textBox1.TabIndex = 34;
            // 
            // button_mines
            // 
            this.button_mines.Location = new System.Drawing.Point(346, 171);
            this.button_mines.Name = "button_mines";
            this.button_mines.Size = new System.Drawing.Size(51, 44);
            this.button_mines.TabIndex = 29;
            this.button_mines.Text = "-";
            this.button_mines.UseVisualStyleBackColor = true;
            this.button_mines.Click += new System.EventHandler(this.button_mines_Click);
            // 
            // textBox_qty
            // 
            this.textBox_qty.Location = new System.Drawing.Point(257, 121);
            this.textBox_qty.Name = "textBox_qty";
            this.textBox_qty.Size = new System.Drawing.Size(140, 27);
            this.textBox_qty.TabIndex = 22;
            // 
            // button_scandiskon
            // 
            this.button_scandiskon.Location = new System.Drawing.Point(163, 187);
            this.button_scandiskon.Name = "button_scandiskon";
            this.button_scandiskon.Size = new System.Drawing.Size(57, 29);
            this.button_scandiskon.TabIndex = 33;
            this.button_scandiskon.Text = "Scan";
            this.button_scandiskon.UseVisualStyleBackColor = true;
            this.button_scandiskon.Click += new System.EventHandler(this.button_scandiskon_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(308, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "Qty";
            // 
            // textBox_diskon
            // 
            this.textBox_diskon.Location = new System.Drawing.Point(17, 188);
            this.textBox_diskon.Name = "textBox_diskon";
            this.textBox_diskon.Size = new System.Drawing.Size(140, 27);
            this.textBox_diskon.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 21);
            this.label11.TabIndex = 31;
            this.label11.Text = "Voucher Diskon";
            // 
            // button_caribrg
            // 
            this.button_caribrg.Location = new System.Drawing.Point(133, 55);
            this.button_caribrg.Name = "button_caribrg";
            this.button_caribrg.Size = new System.Drawing.Size(51, 29);
            this.button_caribrg.TabIndex = 21;
            this.button_caribrg.Text = "Cari";
            this.button_caribrg.UseVisualStyleBackColor = true;
            this.button_caribrg.Click += new System.EventHandler(this.button_caribrg_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Kode Barang";
            // 
            // textBox_harga
            // 
            this.textBox_harga.Location = new System.Drawing.Point(17, 121);
            this.textBox_harga.Name = "textBox_harga";
            this.textBox_harga.Size = new System.Drawing.Size(140, 27);
            this.textBox_harga.TabIndex = 20;
            this.textBox_harga.TextChanged += new System.EventHandler(this.textBox_harga_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Harga";
            // 
            // textBox_namabrg
            // 
            this.textBox_namabrg.Location = new System.Drawing.Point(227, 56);
            this.textBox_namabrg.Name = "textBox_namabrg";
            this.textBox_namabrg.Size = new System.Drawing.Size(170, 27);
            this.textBox_namabrg.TabIndex = 20;
            // 
            // textBox_kodebarang
            // 
            this.textBox_kodebarang.Location = new System.Drawing.Point(17, 56);
            this.textBox_kodebarang.Name = "textBox_kodebarang";
            this.textBox_kodebarang.Size = new System.Drawing.Size(119, 27);
            this.textBox_kodebarang.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Nama Barang";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(176, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 50);
            this.button1.TabIndex = 29;
            this.button1.Text = "Scanner Barcode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_simpan
            // 
            this.button_simpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_simpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_simpan.Location = new System.Drawing.Point(330, 504);
            this.button_simpan.Name = "button_simpan";
            this.button_simpan.Size = new System.Drawing.Size(97, 44);
            this.button_simpan.TabIndex = 28;
            this.button_simpan.Text = "Simpan";
            this.button_simpan.UseVisualStyleBackColor = true;
            this.button_simpan.Click += new System.EventHandler(this.button_simpan_Click);
            // 
            // button_baru
            // 
            this.button_baru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_baru.Location = new System.Drawing.Point(57, 504);
            this.button_baru.Name = "button_baru";
            this.button_baru.Size = new System.Drawing.Size(97, 44);
            this.button_baru.TabIndex = 27;
            this.button_baru.Text = "Baru";
            this.button_baru.UseVisualStyleBackColor = true;
            this.button_baru.Click += new System.EventHandler(this.button_baru_Click);
            // 
            // textBox_kembali
            // 
            this.textBox_kembali.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_kembali.Location = new System.Drawing.Point(798, 527);
            this.textBox_kembali.Name = "textBox_kembali";
            this.textBox_kembali.Size = new System.Drawing.Size(174, 27);
            this.textBox_kembali.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(838, 468);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 21);
            this.label12.TabIndex = 33;
            this.label12.Text = "Uang Bayar";
            // 
            // textBox_bayar
            // 
            this.textBox_bayar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_bayar.Location = new System.Drawing.Point(798, 492);
            this.textBox_bayar.Name = "textBox_bayar";
            this.textBox_bayar.Size = new System.Drawing.Size(174, 27);
            this.textBox_bayar.TabIndex = 32;
            // 
            // label_totalseluruh
            // 
            this.label_totalseluruh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_totalseluruh.AutoSize = true;
            this.label_totalseluruh.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalseluruh.Location = new System.Drawing.Point(708, 510);
            this.label_totalseluruh.Name = "label_totalseluruh";
            this.label_totalseluruh.Size = new System.Drawing.Size(0, 25);
            this.label_totalseluruh.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(490, 510);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(218, 25);
            this.label10.TabIndex = 30;
            this.label10.Text = "TOTAL BELANJA :  Rp.";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(469, 462);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(10, 27);
            this.textBox2.TabIndex = 35;
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // UC_FormTransaksiPenjualan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox_kembali);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox_bayar);
            this.Controls.Add(this.label_totalseluruh);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_simpan);
            this.Controls.Add(this.button_baru);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox_transaksijual);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_FormTransaksiPenjualan";
            this.Size = new System.Drawing.Size(992, 580);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_transaksijual.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_transaksijual)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_kwitansi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_nokwitansi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox_transaksijual;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_namauser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_cariuser;
        private System.Windows.Forms.TextBox textBox_iduser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_caribrg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_namabrg;
        public System.Windows.Forms.TextBox textBox_kodebarang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_mines;
        private System.Windows.Forms.TextBox textBox_qty;
        private System.Windows.Forms.Button button_scandiskon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_diskon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_harga;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_simpan;
        private System.Windows.Forms.Button button_baru;
        private System.Windows.Forms.DataGridView dataGridView_transaksijual;
        private System.Windows.Forms.TextBox textBox_kembali;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_bayar;
        private System.Windows.Forms.Label label_totalseluruh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
    }
}
