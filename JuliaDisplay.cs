using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace FunktionenTheorie
{
    public partial class JuliaDisplay : Form
    {
        public JuliaDisplay()
        {
            InitializeComponent();
        }

        private void JuliaDisplay_Load(object sender, EventArgs e)
        {
            juliaPictureBox.Width = Julia.WindowSize.Width;
            juliaPictureBox.Height = Julia.WindowSize.Height;

            ClientSize = new System.Drawing.Size(juliaPictureBox.Right, juliaPictureBox.Bottom);

            juliaPictureBox.Image = Julia.PixelsInJulia[0];
            juliaPictureBox.Visible = true;
        }

        private void juliaPictureBox_Click(object sender, EventArgs e)
        {
            if (!juliaPlayBackgroundWorker.IsBusy)
            {
                juliaPlayBackgroundWorker.RunWorkerAsync();
            }
            else
            {
                juliaPlayBackgroundWorker.CancelAsync();
            }
        }

        private void juliaPlayBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int totalFrames = Julia.TotalFrames,
                frame = 0; 

            while (true)
            {
                juliaPlayBackgroundWorker.ReportProgress(1, frame);
                System.Threading.Thread.Sleep(30);

                frame++;
                if (frame >= totalFrames)
                {
                    frame = 0;
                }
            }
        }

        private void juliaPlayBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int frame = (int)e.UserState;
            juliaPictureBox.Image = Julia.PixelsInJulia[frame];
            juliaPictureBox.Update();
        }
    }
}
