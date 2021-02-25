namespace pointofsale.controlform
{
    partial class Barang
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
            this.groupBox_databrg = new System.Windows.Forms.GroupBox();
            this.dataGridView_caribrg = new System.Windows.Forms.DataGridView();
            this.textBox_caribrg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_databrg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_caribrg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_databrg
            // 
            this.groupBox_databrg.BackColor = System.Drawing.Color.White;
            this.groupBox_databrg.Controls.Add(this.dataGridView_caribrg);
            this.groupBox_databrg.Controls.Add(this.textBox_caribrg);
            this.groupBox_databrg.Controls.Add(this.label1);
            this.groupBox_databrg.Location = new System.Drawing.Point(24, 23);
            this.groupBox_databrg.Name = "groupBox_databrg";
            this.groupBox_databrg.Size = new System.Drawing.Size(820, 384);
            this.groupBox_databrg.TabIndex = 3;
            this.groupBox_databrg.TabStop = false;
            this.groupBox_databrg.Text = "Data Barang";
            // 
            // dataGridView_caribrg
            // 
            this.dataGridView_caribrg.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_caribrg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_caribrg.Location = new System.Drawing.Point(19, 82);
            this.dataGridView_caribrg.Name = "dataGridView_caribrg";
            this.dataGridView_caribrg.Size = new System.Drawing.Size(780, 284);
            this.dataGridView_caribrg.TabIndex = 2;
            this.dataGridView_caribrg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_caribrg_CellDoubleClick_1);
            // 
            // textBox_caribrg
            // 
            this.textBox_caribrg.Location = new System.Drawing.Point(311, 28);
            this.textBox_caribrg.Name = "textBox_caribrg";
            this.textBox_caribrg.Size = new System.Drawing.Size(336, 27);
            this.textBox_caribrg.TabIndex = 0;
            this.textBox_caribrg.TextChanged += new System.EventHandler(this.textBox_caribrg_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cari Barang (ID/Nama)";
            // 
            // Barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 431);
            this.Controls.Add(this.groupBox_databrg);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Barang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Barang";
            this.groupBox_databrg.ResumeLayout(false);
            this.groupBox_databrg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_caribrg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_databrg;
        private System.Windows.Forms.DataGridView dataGridView_caribrg;
        private System.Windows.Forms.TextBox textBox_caribrg;
        private System.Windows.Forms.Label label1;
    }
}