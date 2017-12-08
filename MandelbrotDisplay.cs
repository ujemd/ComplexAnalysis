using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunktionenTheorie
{
    public partial class MandelbrotDisplay : Form
    {
        public MandelbrotDisplay()
        {
            InitializeComponent();
        }

        private void MandelbrotDisplay_Load(object sender, EventArgs e)
        {
            mandelbrotPictureBox.Width = Mandelbrot.WindowSize.Width;
            mandelbrotPictureBox.Height = Mandelbrot.WindowSize.Height;

            ClientSize = new System.Drawing.Size(mandelbrotPictureBox.Right, mandelbrotPictureBox.Bottom);

            Bitmap mandelbrotBitmap = Mandelbrot.PixelsInMandelbrot;
            mandelbrotPictureBox.Image = mandelbrotBitmap;
            mandelbrotPictureBox.Visible = true;
        }
    }
}
