namespace pointofsale.controlform
{
    partial class Feedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Feedback));
            this.pb_smile = new System.Windows.Forms.PictureBox();
            this.pb_sad = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_smile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sad)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_smile
            // 
            this.pb_smile.Image = ((System.Drawing.Image)(resources.GetObject("pb_smile.Image")));
            this.pb_smile.Location = new System.Drawing.Point(90, 106);
            this.pb_smile.Name = "pb_smile";
            this.pb_smile.Size = new System.Drawing.Size(193, 158);
            this.pb_smile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_smile.TabIndex = 2;
            this.pb_smile.TabStop = false;
            this.pb_smile.Click += new System.EventHandler(this.pb_smile_Click);
            // 
            // pb_sad
            // 
            this.pb_sad.BackColor = System.Drawing.Color.White;
            this.pb_sad.Image = ((System.Drawing.Image)(resources.GetObject("pb_sad.Image")));
            this.pb_sad.Location = new System.Drawing.Point(402, 106);
            this.pb_sad.Name = "pb_sad";
            this.pb_sad.Size = new System.Drawing.Size(193, 158);
            this.pb_sad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_sad.TabIndex = 3;
            this.pb_sad.TabStop = false;
            this.pb_sad.Click += new System.EventHandler(this.pb_sad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "PENILAIAN KAMI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 41);
            this.label2.TabIndex = 5;
            this.label2.Text = "PUAS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(395, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 41);
            this.label3.TabIndex = 6;
            this.label3.Text = "TIDAK PUAS";
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(682, 383);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_sad);
            this.Controls.Add(this.pb_smile);
            this.Name = "Feedback";
            this.Text = "Feedback";
            ((System.ComponentModel.ISupportInitialize)(this.pb_smile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_smile;
        private System.Windows.Forms.PictureBox pb_sad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}