namespace Lab_PictureViewer
{
    partial class Picture
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
            this.PB1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            this.SuspendLayout();
            // 
            // PB1
            // 
            this.PB1.BackColor = System.Drawing.SystemColors.Control;
            this.PB1.Location = new System.Drawing.Point(12, 12);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(505, 413);
            this.PB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB1.TabIndex = 0;
            this.PB1.TabStop = false;
            // 
            // Picture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 437);
            this.Controls.Add(this.PB1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Picture";
            this.Text = "Picture";
            this.Load += new System.EventHandler(this.Picture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB1;
    }
}