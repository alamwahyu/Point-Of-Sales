namespace pointofsale.controlform
{
    partial class FormUbahPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUbahPassword));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_segar = new System.Windows.Forms.Button();
            this.button_simpan = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.validasi2 = new System.Windows.Forms.Label();
            this.textBox_passnew = new System.Windows.Forms.TextBox();
            this.textBox_passverif = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.validasi1 = new System.Windows.Forms.Label();
            this.textBox_passini = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(32, 304);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(147, 25);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ubah Password Baru";
            // 
            // button_segar
            // 
            this.button_segar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_segar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_segar.BackgroundImage")));
            this.button_segar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_segar.Location = new System.Drawing.Point(32, 380);
            this.button_segar.Name = "button_segar";
            this.button_segar.Size = new System.Drawing.Size(267, 38);
            this.button_segar.TabIndex = 15;
            this.button_segar.UseVisualStyleBackColor = false;
            this.button_segar.Click += new System.EventHandler(this.button_segar_Click);
            this.button_segar.MouseEnter += new System.EventHandler(this.button_segar_MouseEnter);
            this.button_segar.MouseLeave += new System.EventHandler(this.button_segar_MouseLeave);
            // 
            // button_simpan
            // 
            this.button_simpan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_simpan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_simpan.BackgroundImage")));
            this.button_simpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_simpan.Location = new System.Drawing.Point(32, 335);
            this.button_simpan.Name = "button_simpan";
            this.button_simpan.Size = new System.Drawing.Size(267, 39);
            this.button_simpan.TabIndex = 14;
            this.button_simpan.UseVisualStyleBackColor = false;
            this.button_simpan.Click += new System.EventHandler(this.button_simpan_Click);
            this.button_simpan.MouseEnter += new System.EventHandler(this.button_simpan_MouseEnter);
            this.button_simpan.MouseLeave += new System.EventHandler(this.button_simpan_MouseLeave);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.validasi2);
            this.groupBox2.Controls.Add(this.textBox_passnew);
            this.groupBox2.Controls.Add(this.textBox_passverif);
            this.groupBox2.Location = new System.Drawing.Point(32, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 144);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Baru";
            // 
            // validasi2
            // 
            this.validasi2.AutoSize = true;
            this.validasi2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validasi2.Location = new System.Drawing.Point(19, 98);
            this.validasi2.Name = "validasi2";
            this.validasi2.Size = new System.Drawing.Size(0, 17);
            this.validasi2.TabIndex = 5;
            // 
            // textBox_passnew
            // 
            this.textBox_passnew.ForeColor = System.Drawing.Color.Silver;
            this.textBox_passnew.Location = new System.Drawing.Point(23, 31);
            this.textBox_passnew.Name = "textBox_passnew";
            this.textBox_passnew.Size = new System.Drawing.Size(222, 27);
            this.textBox_passnew.TabIndex = 2;
            this.textBox_passnew.Text = "  Password Baru";
            this.textBox_passnew.Enter += new System.EventHandler(this.textBox_passnew_Enter);
            this.textBox_passnew.Leave += new System.EventHandler(this.textBox_passnew_Leave);
            // 
            // textBox_passverif
            // 
            this.textBox_passverif.ForeColor = System.Drawing.Color.Silver;
            this.textBox_passverif.Location = new System.Drawing.Point(23, 66);
            this.textBox_passverif.Name = "textBox_passverif";
            this.textBox_passverif.Size = new System.Drawing.Size(222, 27);
            this.textBox_passverif.TabIndex = 4;
            this.textBox_passverif.Text = "  Konfirmasi Password Baru";
            this.textBox_passverif.Enter += new System.EventHandler(this.textBox_passverif_Enter);
            this.textBox_passverif.Leave += new System.EventHandler(this.textBox_passverif_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.validasi1);
            this.groupBox1.Controls.Add(this.textBox_passini);
            this.groupBox1.Location = new System.Drawing.Point(32, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 96);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saat Ini";
            // 
            // validasi1
            // 
            this.validasi1.AutoSize = true;
            this.validasi1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validasi1.Location = new System.Drawing.Point(28, 71);
            this.validasi1.Name = "validasi1";
            this.validasi1.Size = new System.Drawing.Size(0, 17);
            this.validasi1.TabIndex = 1;
            // 
            // textBox_passini
            // 
            this.textBox_passini.ForeColor = System.Drawing.Color.Silver;
            this.textBox_passini.Location = new System.Drawing.Point(23, 39);
            this.textBox_passini.Name = "textBox_passini";
            this.textBox_passini.Size = new System.Drawing.Size(222, 27);
            this.textBox_passini.TabIndex = 0;
            this.textBox_passini.Text = "  Password Saat Ini";
            this.textBox_passini.Enter += new System.EventHandler(this.textBox_passini_Enter);
            this.textBox_passini.Leave += new System.EventHandler(this.textBox_passini_Leave);
            // 
            // FormUbahPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(326, 433);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_segar);
            this.Controls.Add(this.button_simpan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormUbahPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUbahPassword";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_segar;
        private System.Windows.Forms.Button button_simpan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label validasi2;
        private System.Windows.Forms.TextBox textBox_passnew;
        private System.Windows.Forms.TextBox textBox_passverif;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label validasi1;
        private System.Windows.Forms.TextBox textBox_passini;
    }
}