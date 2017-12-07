namespace FunktionenTheorie
{
    partial class JuliaDisplay
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
            this.juliaPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.juliaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // juliaPictureBox
            // 
            this.juliaPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.juliaPictureBox.Location = new System.Drawing.Point(0, 0);
            this.juliaPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.juliaPictureBox.Name = "juliaPictureBox";
            this.juliaPictureBox.Size = new System.Drawing.Size(284, 239);
            this.juliaPictureBox.TabIndex = 0;
            this.juliaPictureBox.TabStop = false;
            this.juliaPictureBox.Visible = false;
            // 
            // JuliaDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.juliaPictureBox);
            this.Name = "JuliaDisplay";
            this.Text = "JuliaDisplay";
            this.Load += new System.EventHandler(this.JuliaDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.juliaPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox juliaPictureBox;

    }
}