namespace pointofsale.controlform
{
    partial class UC_FormProduk
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
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_cariproduk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView_produk = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_hapus = new System.Windows.Forms.Button();
            this.button_simpan = new System.Windows.Forms.Button();
            this.button_ubah = new System.Windows.Forms.Button();
            this.button_baru = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_idproduk = new System.Windows.Forms.TextBox();
            this.comboBox_produk = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_namaproduk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_produk)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 40);
            this.label5.TabIndex = 17;
            this.label5.Text = "Data Produk";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.textBox_cariproduk);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dataGridView_produk);
            this.groupBox3.Location = new System.Drawing.Point(476, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(407, 362);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Produk";
            // 
            // textBox_cariproduk
            // 
            this.textBox_cariproduk.Location = new System.Drawing.Point(215, 25);
            this.textBox_cariproduk.Name = "textBox_cariproduk";
            this.textBox_cariproduk.Size = new System.Drawing.Size(168, 27);
            this.textBox_cariproduk.TabIndex = 8;
            this.textBox_cariproduk.TextChanged += new System.EventHandler(this.textBox_cariproduk_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cari (ID/nama)";
            // 
            // dataGridView_produk
            // 
            this.dataGridView_produk.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_produk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_produk.Location = new System.Drawing.Point(18, 60);
            this.dataGridView_produk.Name = "dataGridView_produk";
            this.dataGridView_produk.Size = new System.Drawing.Size(374, 289);
            this.dataGridView_produk.TabIndex = 0;
            this.dataGridView_produk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_produk_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.button_hapus);
            this.groupBox2.Controls.Add(this.button_simpan);
            this.groupBox2.Controls.Add(this.button_ubah);
            this.groupBox2.Controls.Add(this.button_baru);
            this.groupBox2.Location = new System.Drawing.Point(116, 386);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 109);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proses";
            // 
            // button_hapus
            // 
            this.button_hapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_hapus.Location = new System.Drawing.Point(200, 66);
            this.button_hapus.Name = "button_hapus";
            this.button_hapus.Size = new System.Drawing.Size(116, 37);
            this.button_hapus.TabIndex = 3;
            this.button_hapus.Text = "Hapus";
            this.button_hapus.UseVisualStyleBackColor = true;
            this.button_hapus.Click += new System.EventHandler(this.button_hapus_Click);
            // 
            // button_simpan
            // 
            this.button_simpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_simpan.Location = new System.Drawing.Point(200, 28);
            this.button_simpan.Name = "button_simpan";
            this.button_simpan.Size = new System.Drawing.Size(116, 37);
            this.button_simpan.TabIndex = 2;
            this.button_simpan.Text = "Simpan";
            this.button_simpan.UseVisualStyleBackColor = true;
            this.button_simpan.Click += new System.EventHandler(this.button_simpan_Click);
            // 
            // button_ubah
            // 
            this.button_ubah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_ubah.Location = new System.Drawing.Point(35, 66);
            this.button_ubah.Name = "button_ubah";
            this.button_ubah.Size = new System.Drawing.Size(116, 37);
            this.button_ubah.TabIndex = 1;
            this.button_ubah.Text = "Ubah";
            this.button_ubah.UseVisualStyleBackColor = true;
            this.button_ubah.Click += new System.EventHandler(this.button_ubah_Click);
            // 
            // button_baru
            // 
            this.button_baru.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_baru.Location = new System.Drawing.Point(35, 28);
            this.button_baru.Name = "button_baru";
            this.button_baru.Size = new System.Drawing.Size(116, 37);
            this.button_baru.TabIndex = 0;
            this.button_baru.Text = "Baru";
            this.button_baru.UseVisualStyleBackColor = true;
            this.button_baru.Click += new System.EventHandler(this.button_baru_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.textBox_idproduk);
            this.groupBox1.Controls.Add(this.comboBox_produk);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_namaproduk);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(116, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 247);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Data";
            // 
            // textBox_idproduk
            // 
            this.textBox_idproduk.Location = new System.Drawing.Point(148, 36);
            this.textBox_idproduk.Name = "textBox_idproduk";
            this.textBox_idproduk.Size = new System.Drawing.Size(168, 27);
            this.textBox_idproduk.TabIndex = 7;
            // 
            // comboBox_produk
            // 
            this.comboBox_produk.FormattingEnabled = true;
            this.comboBox_produk.Items.AddRange(new object[] {
            "Sembako",
            "Makanan",
            "Minuman",
            "Kebersihan",
            "Kecantikan"});
            this.comboBox_produk.Location = new System.Drawing.Point(148, 144);
            this.comboBox_produk.Name = "comboBox_produk";
            this.comboBox_produk.Size = new System.Drawing.Size(168, 29);
            this.comboBox_produk.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Jenis Produk";
            // 
            // textBox_namaproduk
            // 
            this.textBox_namaproduk.Location = new System.Drawing.Point(148, 87);
            this.textBox_namaproduk.Name = "textBox_namaproduk";
            this.textBox_namaproduk.Size = new System.Drawing.Size(168, 27);
            this.textBox_namaproduk.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama Produk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Produk";
            // 
            // UC_FormProduk
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "UC_FormProduk";
            this.Size = new System.Drawing.Size(992, 580);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_produk)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_cariproduk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView_produk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_hapus;
        private System.Windows.Forms.Button button_simpan;
        private System.Windows.Forms.Button button_ubah;
        private System.Windows.Forms.Button button_baru;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_idproduk;
        private System.Windows.Forms.ComboBox comboBox_produk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_namaproduk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
