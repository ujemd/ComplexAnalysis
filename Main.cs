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
            Julia.test();
        }

        private void JuliaButton_Click(object sender, EventArgs e)
        {
            Julia.MaxIter = (int)maxIterNumericUpDown.Value;

            Julia.StepPhase = (double)stepPhaseNumericUpDown.Value;

            Julia.CardioidConstants = cardioidCheckBox.Checked;

            if (cartesianCheckBox.Checked)
            {
                Julia.Constant = new Complex((double)realConstantNumericUpDown.Value,
                    (double)imaginaryConstantNumericUpDown.Value);
            }
            else if (polarCheckBox.Checked)
            {
                Julia.Constant = new Complex((double)magnitudeConstantNumericUpDown.Value * Math.Cos((double)phaseConstantNumericUpDown.Value),
                    (double)magnitudeConstantNumericUpDown.Value * Math.Sin((double)phaseConstantNumericUpDown.Value));
            }
            else if (cardioidCheckBox.Checked)
            {
                Julia.Constant = new Complex(0.25, 0);
            }

            Julia.WindowSize = new System.Drawing.Size((int)screenWidthNumericUpDown.Value,
                (int)screenHeightNumericUpDown.Value);

            try
            {
                Julia.computeRadius();
            }
            catch
            {
                toolStripStatusLabel.Text = "Fehler aufgetreten während des Rechnens des Radius";
            }

            if (autosetCheckBox.Checked)
            {
                minRealNumericUpDown.Value = (decimal)-Julia.Radius;
                minImaginaryNumericUpDown.Value = (decimal)-Julia.Radius;
                maxRealNumericUpDown.Value = (decimal)Julia.Radius;
                maxImaginaryNumericUpDown.Value = (decimal)Julia.Radius;
            }

            if(juliaBackgroundWorker.IsBusy != true)
            {
                juliaBackgroundWorker.RunWorkerAsync();
                JuliaButton.Enabled = false;
                mandelbrotButton.Enabled = false;
            }
        }

        private void juliaBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            juliaBackgroundWorker.ReportProgress(1, "Computing Julia Set");

            Complex min = new Complex((double)minRealNumericUpDown.Value, (double)minImaginaryNumericUpDown.Value),
                max = new Complex((double)maxRealNumericUpDown.Value, (double)maxImaginaryNumericUpDown.Value);

            try
            {
                Julia.computeConstantsArray();
            }
            catch
            {
                juliaBackgroundWorker.ReportProgress(100, "Fehler aufgetreten während des Rechnens");
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
                //Julia.PixelsInJulia.Save("C:\\Julia.jpg", ImageFormat.Jpeg);
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
            mandelbrotButton.Enabled = true;
        }

        private void juliaBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripStatusLabel.Text = (string)e.UserState;
            toolStripProgressBar.Style = ProgressBarStyle.Marquee;
        }

        private void mandelbrotButton_Click(object sender, EventArgs e)
        {
            Mandelbrot.MaxIter = (int)maxIterNumericUpDown.Value;

            Mandelbrot.WindowSize = new System.Drawing.Size((int)screenWidthNumericUpDown.Value,
               (int)screenHeightNumericUpDown.Value);

            if (autosetCheckBox.Checked)
            {
                minRealNumericUpDown.Value = (decimal)-2;
                minImaginaryNumericUpDown.Value = (decimal)-1.5;
                maxRealNumericUpDown.Value = (decimal)0.75;
                maxImaginaryNumericUpDown.Value = (decimal)1.5;
            }

            if (mandelbrotBackgroundWorker.IsBusy != true)
            {
                mandelbrotBackgroundWorker.RunWorkerAsync();
                mandelbrotButton.Enabled = false;
                JuliaButton.Enabled = false;
            }
        }

        private void mandelbrotBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            mandelbrotBackgroundWorker.ReportProgress(1, "Computing Mandelbrot Set");

            Complex min = new Complex((double)minRealNumericUpDown.Value, (double)minImaginaryNumericUpDown.Value),
                max = new Complex((double)maxRealNumericUpDown.Value, (double)maxImaginaryNumericUpDown.Value);

            try
            {
                Mandelbrot.screen2ComplexWindow(min, max);
            }
            catch
            {
                mandelbrotBackgroundWorker.ReportProgress(100, "Fehler aufgetreten während des Rechnens des Fensters");
            }

            try
            {
                MandelbrotDisplay mandelbrotDisplay = new MandelbrotDisplay();
                mandelbrotDisplay.ShowDialog();
                //Mandelbrot.PixelsInMandelbrot.Save("C:\\Julia.jpg", ImageFormat.Jpeg);
            }
            catch
            {
                mandelbrotBackgroundWorker.ReportProgress(100, "Fehler aufgetreten");
            }
        }

        private void mandelbrotBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripStatusLabel.Text = (string)e.UserState;
            toolStripProgressBar.Style = ProgressBarStyle.Marquee;
        }

        private void mandelbrotBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripStatusLabel.Text = (string)e.Result;
            toolStripProgressBar.Style = ProgressBarStyle.Continuous;

            mandelbrotButton.Enabled = true;
            JuliaButton.Enabled = true;
        }

        private void autosetCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (autosetCheckBox.Checked)
            {
                minRealNumericUpDown.Enabled = false;
                minImaginaryNumericUpDown.Enabled = false;
                maxRealNumericUpDown.Enabled = false;
                maxImaginaryNumericUpDown.Enabled = false;
            }
            else
            {
                minRealNumericUpDown.Enabled = true;
                minImaginaryNumericUpDown.Enabled = true;
                maxRealNumericUpDown.Enabled = true;
                maxImaginaryNumericUpDown.Enabled = true;
            }
        }

        private void cartesianCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cartesianCheckBox.Checked)
            {
                realConstantNumericUpDown.Enabled = true;
                imaginaryConstantNumericUpDown.Enabled = true;
                cartesianCheckBox.Enabled = false;

                polarCheckBox.Checked = false;
                polarCheckBox.Enabled = true;
                magnitudeConstantNumericUpDown.Enabled = false;
                phaseConstantNumericUpDown.Enabled = false;

                cardioidCheckBox.Checked = false;
                cardioidCheckBox.Enabled = true;
            }
        }

        private void polarCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (polarCheckBox.Checked)
            {
                magnitudeConstantNumericUpDown.Enabled = true;
                phaseConstantNumericUpDown.Enabled = true;
                polarCheckBox.Enabled = false;

                cartesianCheckBox.Checked = false;
                cartesianCheckBox.Enabled = true;
                realConstantNumericUpDown.Enabled = false;
                imaginaryConstantNumericUpDown.Enabled = false;

                cardioidCheckBox.Checked = false;
                cardioidCheckBox.Enabled = true;
            }

        }

        private void cardioidCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cardioidCheckBox.Checked)
            {
                cardioidCheckBox.Enabled = false;

                cartesianCheckBox.Checked = false;
                cartesianCheckBox.Enabled = true;
                realConstantNumericUpDown.Enabled = false;
                imaginaryConstantNumericUpDown.Enabled = false;

                polarCheckBox.Checked = false;
                polarCheckBox.Enabled = true;
                magnitudeConstantNumericUpDown.Enabled = false;
                phaseConstantNumericUpDown.Enabled = false;
            }
        }
    }
}
