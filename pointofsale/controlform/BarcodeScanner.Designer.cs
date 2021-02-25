namespace pointofsale.controlform
{
    partial class BarcodeScanner
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
            this.comboBox_pilihan = new System.Windows.Forms.ComboBox();
            this.dataGridView_scan = new System.Windows.Forms.DataGridView();
            this.textBox_sound = new System.Windows.Forms.TextBox();
            this.comboBox_camera = new System.Windows.Forms.ComboBox();
            this.checkBox_camera = new System.Windows.Forms.CheckBox();
            this.button_select = new System.Windows.Forms.Button();
            this.button_cek = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.pictureBox_camera = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_scan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_camera)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_pilihan
            // 
            this.comboBox_pilihan.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_pilihan.FormattingEnabled = true;
            this.comboBox_pilihan.Items.AddRange(new object[] {
            "Penjualan",
            "Voucher"});
            this.comboBox_pilihan.Location = new System.Drawing.Point(267, 460);
            this.comboBox_pilihan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_pilihan.Name = "comboBox_pilihan";
            this.comboBox_pilihan.Size = new System.Drawing.Size(194, 25);
            this.comboBox_pilihan.TabIndex = 18;
            // 
            // dataGridView_scan
            // 
            this.dataGridView_scan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_scan.Location = new System.Drawing.Point(12, 371);
            this.dataGridView_scan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_scan.Name = "dataGridView_scan";
            this.dataGridView_scan.Size = new System.Drawing.Size(658, 78);
            this.dataGridView_scan.TabIndex = 17;
            this.dataGridView_scan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_scan_CellClick);
            // 
            // textBox_sound
            // 
            this.textBox_sound.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sound.Location = new System.Drawing.Point(12, 460);
            this.textBox_sound.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_sound.Name = "textBox_sound";
            this.textBox_sound.Size = new System.Drawing.Size(240, 23);
            this.textBox_sound.TabIndex = 16;
            // 
            // comboBox_camera
            // 
            this.comboBox_camera.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_camera.FormattingEnabled = true;
            this.comboBox_camera.Location = new System.Drawing.Point(267, 490);
            this.comboBox_camera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_camera.Name = "comboBox_camera";
            this.comboBox_camera.Size = new System.Drawing.Size(194, 25);
            this.comboBox_camera.TabIndex = 15;
            // 
            // checkBox_camera
            // 
            this.checkBox_camera.AutoSize = true;
            this.checkBox_camera.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_camera.Location = new System.Drawing.Point(171, 497);
            this.checkBox_camera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_camera.Name = "checkBox_camera";
            this.checkBox_camera.Size = new System.Drawing.Size(81, 21);
            this.checkBox_camera.TabIndex = 14;
            this.checkBox_camera.Text = "Camera";
            this.checkBox_camera.UseVisualStyleBackColor = true;
            this.checkBox_camera.CheckedChanged += new System.EventHandler(this.checkBox_camera_CheckedChanged);
            // 
            // button_select
            // 
            this.button_select.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_select.Location = new System.Drawing.Point(485, 488);
            this.button_select.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(88, 27);
            this.button_select.TabIndex = 13;
            this.button_select.Text = "Select";
            this.button_select.UseVisualStyleBackColor = true;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // button_cek
            // 
            this.button_cek.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cek.Location = new System.Drawing.Point(588, 458);
            this.button_cek.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_cek.Name = "button_cek";
            this.button_cek.Size = new System.Drawing.Size(81, 59);
            this.button_cek.TabIndex = 12;
            this.button_cek.Text = "Cek Barcode";
            this.button_cek.UseVisualStyleBackColor = true;
            this.button_cek.Click += new System.EventHandler(this.button_cek_Click);
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.Location = new System.Drawing.Point(12, 493);
            this.button_exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(72, 27);
            this.button_exit.TabIndex = 11;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // pictureBox_camera
            // 
            this.pictureBox_camera.BackColor = System.Drawing.Color.White;
            this.pictureBox_camera.Location = new System.Drawing.Point(12, 7);
            this.pictureBox_camera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_camera.Name = "pictureBox_camera";
            this.pictureBox_camera.Size = new System.Drawing.Size(658, 356);
            this.pictureBox_camera.TabIndex = 10;
            this.pictureBox_camera.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // BarcodeScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 527);
            this.Controls.Add(this.comboBox_pilihan);
            this.Controls.Add(this.dataGridView_scan);
            this.Controls.Add(this.textBox_sound);
            this.Controls.Add(this.comboBox_camera);
            this.Controls.Add(this.checkBox_camera);
            this.Controls.Add(this.button_select);
            this.Controls.Add(this.button_cek);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.pictureBox_camera);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "BarcodeScanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BarcodeScanner";
            this.Load += new System.EventHandler(this.BarcodeScanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_scan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_camera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_pilihan;
        public System.Windows.Forms.DataGridView dataGridView_scan;
        private System.Windows.Forms.TextBox textBox_sound;
        private System.Windows.Forms.ComboBox comboBox_camera;
        private System.Windows.Forms.CheckBox checkBox_camera;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.Button button_cek;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.PictureBox pictureBox_camera;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}