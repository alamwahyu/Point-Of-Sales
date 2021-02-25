namespace pointofsale
{
    partial class DasboardManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DasboardManager));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_side = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_keuangan = new System.Windows.Forms.Button();
            this.btn_profil = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.panelleft = new System.Windows.Forms.Panel();
            this.btn_voucher = new System.Windows.Forms.Button();
            this.btn_barang = new System.Windows.Forms.Button();
            this.panelControl = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelleft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_side);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 140);
            this.panel1.TabIndex = 2;
            // 
            // btn_side
            // 
            this.btn_side.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_side.FlatAppearance.BorderSize = 0;
            this.btn_side.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_side.Image = ((System.Drawing.Image)(resources.GetObject("btn_side.Image")));
            this.btn_side.Location = new System.Drawing.Point(157, 1);
            this.btn_side.Name = "btn_side";
            this.btn_side.Size = new System.Drawing.Size(44, 39);
            this.btn_side.TabIndex = 3;
            this.btn_side.UseVisualStyleBackColor = true;
            this.btn_side.Click += new System.EventHandler(this.btn_side_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_keuangan
            // 
            this.btn_keuangan.FlatAppearance.BorderSize = 0;
            this.btn_keuangan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(120)))));
            this.btn_keuangan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_keuangan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_keuangan.ForeColor = System.Drawing.Color.White;
            this.btn_keuangan.Image = ((System.Drawing.Image)(resources.GetObject("btn_keuangan.Image")));
            this.btn_keuangan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_keuangan.Location = new System.Drawing.Point(7, 253);
            this.btn_keuangan.Name = "btn_keuangan";
            this.btn_keuangan.Size = new System.Drawing.Size(200, 56);
            this.btn_keuangan.TabIndex = 9;
            this.btn_keuangan.Text = "Keuangan";
            this.btn_keuangan.UseVisualStyleBackColor = true;
            this.btn_keuangan.Click += new System.EventHandler(this.btn_keuangan_Click);
            // 
            // btn_profil
            // 
            this.btn_profil.FlatAppearance.BorderSize = 0;
            this.btn_profil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(120)))));
            this.btn_profil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_profil.ForeColor = System.Drawing.Color.White;
            this.btn_profil.Image = ((System.Drawing.Image)(resources.GetObject("btn_profil.Image")));
            this.btn_profil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_profil.Location = new System.Drawing.Point(8, 194);
            this.btn_profil.Name = "btn_profil";
            this.btn_profil.Size = new System.Drawing.Size(200, 56);
            this.btn_profil.TabIndex = 8;
            this.btn_profil.Text = "My Profil";
            this.btn_profil.UseVisualStyleBackColor = true;
            this.btn_profil.Click += new System.EventHandler(this.btn_profil_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.Image")));
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(2, 663);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(204, 56);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.White;
            this.panelSide.Location = new System.Drawing.Point(0, 139);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(7, 56);
            this.panelSide.TabIndex = 3;
            // 
            // btn_home
            // 
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(120)))));
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(7, 139);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(200, 56);
            this.btn_home.TabIndex = 3;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lb_username);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.lbl_Time);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(208, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(992, 140);
            this.panel3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 44);
            this.label3.TabIndex = 6;
            this.label3.Text = "POINT OF SALE";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(827, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selamat datang,";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(827, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manager";
            // 
            // lb_username
            // 
            this.lb_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.ForeColor = System.Drawing.Color.White;
            this.lb_username.Location = new System.Drawing.Point(827, 50);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(0, 23);
            this.lb_username.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(744, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 68);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_Time
            // 
            this.lbl_Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Time.ForeColor = System.Drawing.Color.White;
            this.lbl_Time.Location = new System.Drawing.Point(402, 41);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(143, 32);
            this.lbl_Time.TabIndex = 0;
            this.lbl_Time.Text = "HH:MM:SS";
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panelleft.Controls.Add(this.button1);
            this.panelleft.Controls.Add(this.btn_voucher);
            this.panelleft.Controls.Add(this.btn_barang);
            this.panelleft.Controls.Add(this.btn_keuangan);
            this.panelleft.Controls.Add(this.btn_profil);
            this.panelleft.Controls.Add(this.btn_logout);
            this.panelleft.Controls.Add(this.panelSide);
            this.panelleft.Controls.Add(this.btn_home);
            this.panelleft.Controls.Add(this.panel1);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft.Location = new System.Drawing.Point(0, 0);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(208, 720);
            this.panelleft.TabIndex = 4;
            // 
            // btn_voucher
            // 
            this.btn_voucher.FlatAppearance.BorderSize = 0;
            this.btn_voucher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(120)))));
            this.btn_voucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voucher.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voucher.ForeColor = System.Drawing.Color.White;
            this.btn_voucher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_voucher.Location = new System.Drawing.Point(7, 371);
            this.btn_voucher.Name = "btn_voucher";
            this.btn_voucher.Size = new System.Drawing.Size(200, 56);
            this.btn_voucher.TabIndex = 11;
            this.btn_voucher.Text = "Laporan Voucher";
            this.btn_voucher.UseVisualStyleBackColor = true;
            this.btn_voucher.Click += new System.EventHandler(this.btn_voucher_Click);
            // 
            // btn_barang
            // 
            this.btn_barang.FlatAppearance.BorderSize = 0;
            this.btn_barang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(120)))));
            this.btn_barang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_barang.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_barang.ForeColor = System.Drawing.Color.White;
            this.btn_barang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_barang.Location = new System.Drawing.Point(7, 312);
            this.btn_barang.Name = "btn_barang";
            this.btn_barang.Size = new System.Drawing.Size(200, 56);
            this.btn_barang.TabIndex = 10;
            this.btn_barang.Text = "Laporan Barang";
            this.btn_barang.UseVisualStyleBackColor = true;
            this.btn_barang.Click += new System.EventHandler(this.btn_barang_Click);
            // 
            // panelControl
            // 
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(208, 140);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(992, 580);
            this.panelControl.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(120)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(8, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 56);
            this.button1.TabIndex = 12;
            this.button1.Text = "Laporan Penilaian";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DasboardManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelleft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DasboardManager";
            this.Text = "DasboardManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelleft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_side;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_keuangan;
        private System.Windows.Forms.Button btn_profil;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_barang;
        private System.Windows.Forms.Button btn_voucher;
        private System.Windows.Forms.Button button1;
    }
}