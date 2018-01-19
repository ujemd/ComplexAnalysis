using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Drawing;

namespace FunktionenTheorie
{
    class Mandelbrot
    {
        private static double[] _windowReals;
        private static double[] _windowImaginaries;
        private static Bitmap _pixelsInMandelbrot;
        private static int _maxIter = 4;
        private static Size _windowSize;
        private static double _functionOrder = 2;
        private static double _goldenRatio = (1 + Math.Sqrt(5)) / 2;
        private static Color[] _colorPalette = { Color.Black, Color.Red, Color.Orange, Color.White, Color.Blue,
                                                   Color.DarkBlue };
        private static Color[] _colorRange;

        public static int MaxIter
        {
            set { _maxIter = value; }
        }

        public static Bitmap PixelsInMandelbrot
        {
            get { return _pixelsInMandelbrot; }
        }

        public static Size WindowSize
        {
            get { return _windowSize; }
            set { _windowSize = value; }
        }

        public static double FunctionOrder
        {
            set { _functionOrder = value; }
        }

        public static double[] pixel2Complex(double minComplex, double maxComplex, int maxResolution)
        {
            double[] complexWindow1DValues = new double[maxResolution];

            for (int pixel = 0; pixel != maxResolution; pixel++)
            {
                //x = a + (p/width) * (b - a)
                complexWindow1DValues[pixel] = minComplex + ((double)pixel / maxResolution) * (maxComplex - minComplex);
            }

            return complexWindow1DValues;
        }

        public static void getColorRange()
        {
            Color[] colorRange = new Color[_maxIter + 1];

            Color c0, c1;

            double colorDelta = 1.0 / (_colorPalette.Length - 1),
                globalRatio = 0,
                localRatio = 0;

            int index0 = 0,
                index1 = 0,
                r0, g0, b0,
                r1, g1, b1,
                dr, dg, db,
                r, g, b;

            for (int iter = 0; iter <= _maxIter; iter++)
            {
                globalRatio = (double)iter / _maxIter;
                index0 = (int)(globalRatio / colorDelta);
                index1 = Math.Min(_colorPalette.Length - 1, index0 + 1);
                localRatio = (globalRatio - index0 * colorDelta) / colorDelta;

                c0 = _colorPalette[index0];
                r0 = c0.R; g0 = c0.G; b0 = c0.B;

                c1 = _colorPalette[index1];
                r1 = c1.R; g1 = c1.G; b1 = c1.B;

                dr = r1 - r0;
                dg = g1 - g0;
                db = b1 - b0;

                r = (int)(r0 + localRatio * dr);
                g = (int)(g0 + localRatio * dg);
                b = (int)(b0 + localRatio * db);

                colorRange[iter] = Color.FromArgb(r, g, b);
            }

            //for (int iter = 0; iter <= _maxIter; iter++)
            //{
            //    grayValue = 255 * (Math.Exp(50 * (double)(iter - _maxIter) / _maxIter));
            //    colorRange[iter] = Color.FromArgb((int)grayValue, (int)grayValue, (int)grayValue);
            //}

            _colorRange = colorRange;
        }

        public static Complex computeQuadraticFunction(Complex z, Complex constant)
        {
            Complex f = Complex.Pow(z, _functionOrder) + constant;
            return f;
        }

        public static int isInMandelbrot(Complex constant)
        {
            Complex f = 0;

            for (int iteration = 0; iteration < _maxIter; iteration++)
            {
                f = computeQuadraticFunction(f, constant);
                //Console.WriteLine("Iteration: {0}, f = {1}\n", iteration, f);

                if (f.Magnitude > 2)
                {
                    return _maxIter - iteration; // is not in the filled-in Julia, is in Basin
                }
            }

            return 0; // is in filled-in Julia
        }

        public static void screen2ComplexWindow(Complex min, Complex max)
        {
            int width = _windowSize.Width,
                height = _windowSize.Height,
                colorIndex = 0;

            _windowReals = pixel2Complex(min.Real, max.Real, width);
            _windowImaginaries = pixel2Complex(min.Imaginary, max.Imaginary, height);
            getColorRange();

            Bitmap pixelsInMandelbrot = new Bitmap(width, height);

            for (int realIndex = 0; realIndex < width; realIndex++)
            {
                for (int imgIndex = 0; imgIndex < height; imgIndex++)
                {
                    colorIndex = isInMandelbrot(new Complex(_windowReals[realIndex], _windowImaginaries[imgIndex]));
                    pixelsInMandelbrot.SetPixel(realIndex, imgIndex, _colorRange[colorIndex]);
                }
            }

            _pixelsInMandelbrot = pixelsInMandelbrot;
        }
    }
}
