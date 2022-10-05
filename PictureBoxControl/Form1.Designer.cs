namespace PictureBoxControl
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picSlika = new System.Windows.Forms.PictureBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // picSlika
            // 
            this.picSlika.Image = ((System.Drawing.Image)(resources.GetObject("picSlika.Image")));
            this.picSlika.Location = new System.Drawing.Point(83, 72);
            this.picSlika.Name = "picSlika";
            this.picSlika.Size = new System.Drawing.Size(276, 160);
            this.picSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSlika.TabIndex = 0;
            this.picSlika.TabStop = false;
            this.picSlika.Visible = false;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(177, 33);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikazi Sliku";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 268);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.picSlika);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picSlika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSlika;
        private System.Windows.Forms.Button btnPrikazi;
    }
}

