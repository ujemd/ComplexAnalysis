using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace FunktionenTheorie
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void JuliaButton_Click(object sender, EventArgs e)
        {
            if(juliaBackgroundWorker.IsBusy != true)
            {
                juliaBackgroundWorker.RunWorkerAsync();
                JuliaButton.Enabled = false;
            }
        }

        private void juliaBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            juliaBackgroundWorker.ReportProgress(1, "Computing Julia Set");

            Julia.Constant = new Complex((double)realConstantNumericUpDown.Value,
                (double)imaginaryConstantNumericUpDown.Value);

            Julia.MaxIter = (int)maxIterNumericUpDown.Value;

            Julia.Size = new System.Drawing.Size((int)screenWidthNumericUpDown.Value,
                (int)screenHeightNumericUpDown.Value);

            Complex min = new Complex((double)minRealNumericUpDown.Value, (double)minImaginaryNumericUpDown.Value),
                max = new Complex((double)maxRealNumericUpDown.Value, (double)maxImaginaryNumericUpDown.Value);

            try
            {
                Julia.computeRadius();
            }
            catch
            {
                juliaBackgroundWorker.ReportProgress(100, "Fehler aufgetreten während des Rechnens des Radius");
            }

            try
            {
                Julia.screen2ComplexWindow(min, max);
            }
            catch
            {
                juliaBackgroundWorker.ReportProgress(100, "Fehler aufgetreten während des Rechnens des Fensters");
            }


            try
            {
                JuliaDisplay juliaDisplay = new JuliaDisplay();
                juliaDisplay.ShowDialog();
                Julia.PixelsInJulia.Save("C:\\Julia.jpg", ImageFormat.Jpeg);
            }
            catch
            {
                juliaBackgroundWorker.ReportProgress(100, "Fehler aufgetreten");
            }
        }

        private void juliaBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripStatusLabel.Text = (string)e.Result;
            toolStripProgressBar.Style = ProgressBarStyle.Continuous;

            JuliaButton.Enabled = true;
        }

        private void juliaBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripStatusLabel.Text = (string)e.UserState;
            toolStripProgressBar.Style = ProgressBarStyle.Marquee;
        }
    }
}
