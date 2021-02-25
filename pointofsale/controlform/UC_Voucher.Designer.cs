namespace pointofsale.controlform
{
    partial class UC_Voucher
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_qr = new System.Windows.Forms.Button();
            this.button_segar = new System.Windows.Forms.Button();
            this.button_hapus = new System.Windows.Forms.Button();
            this.button_simpan = new System.Windows.Forms.Button();
            this.textBox_nominal = new System.Windows.Forms.TextBox();
            this.textBox_kode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(383, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 299);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(434, 245);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.button_qr);
            this.groupBox1.Controls.Add(this.button_segar);
            this.groupBox1.Controls.Add(this.button_hapus);
            this.groupBox1.Controls.Add(this.button_simpan);
            this.groupBox1.Controls.Add(this.textBox_nominal);
            this.groupBox1.Controls.Add(this.textBox_kode);
            this.groupBox1.Location = new System.Drawing.Point(144, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 299);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Data";
            // 
            // button_qr
            // 
            this.button_qr.BackColor = System.Drawing.Color.LightGray;
            this.button_qr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_qr.Location = new System.Drawing.Point(16, 132);
            this.button_qr.Name = "button_qr";
            this.button_qr.Size = new System.Drawing.Size(194, 34);
            this.button_qr.TabIndex = 5;
            this.button_qr.Text = "Cetak QR Code";
            this.button_qr.UseVisualStyleBackColor = false;
            this.button_qr.Click += new System.EventHandler(this.button_qr_Click);
            this.button_qr.MouseEnter += new System.EventHandler(this.button_qr_MouseEnter);
            this.button_qr.MouseLeave += new System.EventHandler(this.button_qr_MouseLeave);
            // 
            // button_segar
            // 
            this.button_segar.BackColor = System.Drawing.Color.LightGray;
            this.button_segar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_segar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_segar.Location = new System.Drawing.Point(16, 252);
            this.button_segar.Name = "button_segar";
            this.button_segar.Size = new System.Drawing.Size(194, 34);
            this.button_segar.TabIndex = 4;
            this.button_segar.Text = "Refresh";
            this.button_segar.UseVisualStyleBackColor = false;
            this.button_segar.Click += new System.EventHandler(this.button_segar_Click);
            this.button_segar.MouseEnter += new System.EventHandler(this.button_segar_MouseEnter);
            this.button_segar.MouseLeave += new System.EventHandler(this.button_segar_MouseLeave);
            // 
            // button_hapus
            // 
            this.button_hapus.BackColor = System.Drawing.Color.LightGray;
            this.button_hapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_hapus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hapus.Location = new System.Drawing.Point(16, 212);
            this.button_hapus.Name = "button_hapus";
            this.button_hapus.Size = new System.Drawing.Size(194, 34);
            this.button_hapus.TabIndex = 3;
            this.button_hapus.Text = "Hapus";
            this.button_hapus.UseVisualStyleBackColor = false;
            this.button_hapus.Click += new System.EventHandler(this.button_hapus_Click);
            this.button_hapus.MouseEnter += new System.EventHandler(this.button_hapus_MouseEnter);
            this.button_hapus.MouseLeave += new System.EventHandler(this.button_hapus_MouseLeave);
            // 
            // button_simpan
            // 
            this.button_simpan.BackColor = System.Drawing.Color.LightGray;
            this.button_simpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_simpan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_simpan.Location = new System.Drawing.Point(16, 172);
            this.button_simpan.Name = "button_simpan";
            this.button_simpan.Size = new System.Drawing.Size(194, 34);
            this.button_simpan.TabIndex = 2;
            this.button_simpan.Text = "Simpan";
            this.button_simpan.UseVisualStyleBackColor = false;
            this.button_simpan.Click += new System.EventHandler(this.button_simpan_Click);
            this.button_simpan.MouseEnter += new System.EventHandler(this.button_simpan_MouseEnter);
            this.button_simpan.MouseLeave += new System.EventHandler(this.button_simpan_MouseLeave);
            // 
            // textBox_nominal
            // 
            this.textBox_nominal.ForeColor = System.Drawing.Color.Silver;
            this.textBox_nominal.Location = new System.Drawing.Point(16, 91);
            this.textBox_nominal.Name = "textBox_nominal";
            this.textBox_nominal.Size = new System.Drawing.Size(194, 27);
            this.textBox_nominal.TabIndex = 1;
            this.textBox_nominal.Text = "  Nominal Potongan";
            this.textBox_nominal.Enter += new System.EventHandler(this.textBox_nominal_Enter);
            this.textBox_nominal.Leave += new System.EventHandler(this.textBox_nominal_Leave);
            // 
            // textBox_kode
            // 
            this.textBox_kode.ForeColor = System.Drawing.Color.Silver;
            this.textBox_kode.Location = new System.Drawing.Point(16, 47);
            this.textBox_kode.Name = "textBox_kode";
            this.textBox_kode.Size = new System.Drawing.Size(194, 27);
            this.textBox_kode.TabIndex = 0;
            this.textBox_kode.Text = "  Kode Voucher Baru";
            this.textBox_kode.Enter += new System.EventHandler(this.textBox_kode_Enter);
            this.textBox_kode.Leave += new System.EventHandler(this.textBox_kode_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Voucher Diskon";
            // 
            // UC_Voucher
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "UC_Voucher";
            this.Size = new System.Drawing.Size(992, 580);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_qr;
        private System.Windows.Forms.Button button_segar;
        private System.Windows.Forms.Button button_hapus;
        private System.Windows.Forms.Button button_simpan;
        private System.Windows.Forms.TextBox textBox_nominal;
        private System.Windows.Forms.TextBox textBox_kode;
        private System.Windows.Forms.Label label1;
    }
}
