namespace pointofsale.controlform
{
    partial class Produk
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_cariproduk = new System.Windows.Forms.TextBox();
            this.dataGridView_dialogproduk = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dialogproduk)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dialog Produk";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dataGridView_dialogproduk);
            this.groupBox1.Controls.Add(this.textBox_cariproduk);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(41, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Produk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cari Produk (ID/Nama)";
            // 
            // textBox_cariproduk
            // 
            this.textBox_cariproduk.Location = new System.Drawing.Point(247, 31);
            this.textBox_cariproduk.Name = "textBox_cariproduk";
            this.textBox_cariproduk.Size = new System.Drawing.Size(336, 27);
            this.textBox_cariproduk.TabIndex = 2;
            this.textBox_cariproduk.TextChanged += new System.EventHandler(this.textBox_cariproduk_TextChanged);
            // 
            // dataGridView_dialogproduk
            // 
            this.dataGridView_dialogproduk.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_dialogproduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_dialogproduk.Location = new System.Drawing.Point(24, 82);
            this.dataGridView_dialogproduk.Name = "dataGridView_dialogproduk";
            this.dataGridView_dialogproduk.Size = new System.Drawing.Size(696, 213);
            this.dataGridView_dialogproduk.TabIndex = 4;
            this.dataGridView_dialogproduk.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_dialogproduk_CellDoubleClick);
            // 
            // Produk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 418);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Produk";
            this.Text = "Produk";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dialogproduk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_dialogproduk;
        private System.Windows.Forms.TextBox textBox_cariproduk;
        private System.Windows.Forms.Label label1;
    }
}