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

            Bitmap juliaBitmap = Julia.PixelsInJulia;
            juliaPictureBox.Image = juliaBitmap;
            juliaPictureBox.Visible = true;
        }
    }
}
