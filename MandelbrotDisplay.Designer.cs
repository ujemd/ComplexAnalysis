namespace FunktionenTheorie
{
    partial class MandelbrotDisplay
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
            this.mandelbrotPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mandelbrotPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mandelbrotPictureBox
            // 
            this.mandelbrotPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.mandelbrotPictureBox.Location = new System.Drawing.Point(0, 0);
            this.mandelbrotPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.mandelbrotPictureBox.Name = "mandelbrotPictureBox";
            this.mandelbrotPictureBox.Size = new System.Drawing.Size(284, 263);
            this.mandelbrotPictureBox.TabIndex = 0;
            this.mandelbrotPictureBox.TabStop = false;
            this.mandelbrotPictureBox.Visible = false;
            // 
            // MandelbrotDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.mandelbrotPictureBox);
            this.Name = "MandelbrotDisplay";
            this.Text = "Mandelbrot";
            this.Load += new System.EventHandler(this.MandelbrotDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mandelbrotPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mandelbrotPictureBox;
    }
}