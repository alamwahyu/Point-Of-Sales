namespace pointofsale.controlform
{
    partial class Supplier
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
            this.dataGridView_dialogsupplier = new System.Windows.Forms.DataGridView();
            this.textBox_carisupplier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dialogsupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dialog Supplier";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.dataGridView_dialogsupplier);
            this.groupBox1.Controls.Add(this.textBox_carisupplier);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(48, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 308);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Supplier";
            // 
            // dataGridView_dialogsupplier
            // 
            this.dataGridView_dialogsupplier.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_dialogsupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_dialogsupplier.Location = new System.Drawing.Point(24, 82);
            this.dataGridView_dialogsupplier.Name = "dataGridView_dialogsupplier";
            this.dataGridView_dialogsupplier.Size = new System.Drawing.Size(696, 213);
            this.dataGridView_dialogsupplier.TabIndex = 4;
            this.dataGridView_dialogsupplier.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_dialogsupplier_CellDoubleClick);
            // 
            // textBox_carisupplier
            // 
            this.textBox_carisupplier.Location = new System.Drawing.Point(247, 31);
            this.textBox_carisupplier.Name = "textBox_carisupplier";
            this.textBox_carisupplier.Size = new System.Drawing.Size(336, 27);
            this.textBox_carisupplier.TabIndex = 2;
            this.textBox_carisupplier.TextChanged += new System.EventHandler(this.textBox_carisupplier_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cari Supplier (ID/Nama)";
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(828, 434);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Supplier";
            this.Text = "Supplier";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dialogsupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_dialogsupplier;
        private System.Windows.Forms.TextBox textBox_carisupplier;
        private System.Windows.Forms.Label label1;
    }
}