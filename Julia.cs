using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;

namespace FunktionenTheorie
{
    class Julia
    {
        private static Complex _constant = -1;  //Constant c of f(z) = z^2 + c
        private static Complex[] _constants; //Array with the constants of the main cardioid of the Mandelbrot set.
        private static bool _cardioidConstants = false;
        private static double _2PI = 2 * Math.PI;
        private static double _radius; //Radius R of R = (1 + sqrt(1 + 4|c|))/2 for K(f) condition
        private static double _stepPhase = 0; //step of phase initPhase:stepPhase:initPhase+2PI
        private static double[] _windowReals; //real numbers of display window
        private static Complex[] _windowValues; //complex values of the window
        private static double[] _windowImaginaries; //imaginary numbers of display window
        private static Bitmap[] _pixelsInJulia; //array of frames where each pixel represents a number that belongs or not to K(f)
        private static int _maxIter = 4; //maximum number of iterations for evaluating f^n(z). Also, n.
        private static int _totalFrames = 1; //total of frames to be displayed
        private static Size _windowSize; //Size of window in pixels
        private static double _goldenRatio = (1 + Math.Sqrt(5)) / 2; //constant representing the golden ratio
        private static Color[] _colorPalette = { Color.Black, Color.Red, Color.Orange, Color.White, Color.Blue,
                                                   Color.DarkBlue };
        private static Color[] _colorRange; //contains the color degradation for each iteration of f^n(z) as specified by the _colorPalette

        public static Complex Constant
        {
            set { _constant = value; }
        }

        public static bool CardioidConstants
        {
            set { _cardioidConstants = value; }
        }

        public static double Radius
        {
            get { return _radius; }
        }

        public static double StepPhase
        {
            set { _stepPhase = value; }
        }

        public static int MaxIter
        {
            set { _maxIter = value; }
        }

        public static int TotalFrames
        {
            get { return _totalFrames; }
        }

        public static Bitmap[] PixelsInJulia
        {
            get { return _pixelsInJulia; }
        }

        public static Size WindowSize
        {
            get { return _windowSize; }
            set { _windowSize = value; }
        }

        public static void computeCardioidConstants()
        {
            double phase = 0;

            _constants = new Complex[_totalFrames];

            for (int frame = 0; frame < _totalFrames; frame++)
            {
                _constants[frame] = new Complex(0.5 * Math.Cos(phase) - 0.25 * Math.Cos(2 * phase),
                    0.5 * Math.Sin(phase) - 0.25 * Math.Sin(2 * phase));
                phase += _stepPhase;
            }
        }

        public static void computeCircularConstants()
        {
            double phase = 0,
                magnitude = _constant.Magnitude;

            _constants = new Complex[_totalFrames];

            for (int frame = 0; frame < _totalFrames; frame++)
            {
                _constants[frame] = new Complex(magnitude * Math.Cos(phase),
                    magnitude * Math.Sin(phase));
                phase += _stepPhase;
            }
        }

        public static void computeConstantsArray()
        {
            int totalFrames;

            if (_stepPhase != 0)
            {
                totalFrames = (int)Math.Floor(_2PI / _stepPhase);
            }
            else
            {
                totalFrames = 1;
            }

            _totalFrames = totalFrames;

            if (_cardioidConstants)
            {
                computeCardioidConstants();
            }
            else
            {
                computeCircularConstants();
            }
        }

        /// <summary>
        /// Radius R of R = (1 + sqrt(1 + 4|c|))/2 for K(f) condition
        /// </summary>
        public static void computeRadius()
        {
            _radius = (1 + Math.Sqrt(1 + 4 * _constant.Magnitude))/2;
        }

        /// <summary>
        /// Converts a given pixel position of the window to a complex representation.
        /// Should be used for each dimension of the representation. E.g. once for imaginaries and once for reals.
        /// </summary>
        /// <param name="minComplex">Represents the minimum complex value (either real or complex) of the display window.</param>
        /// <param name="maxComplex">Represents the maximum complex value (either real or complex) of the display window.</param>
        /// <param name="maxResolution">Represents either the pixel width or the height of the display window.</param>
        /// <returns>Returns a range of real or imaginery values that represent the display window.</returns>
        public static double[] pixel2Complex(double minComplex, double maxComplex, int maxResolution)
        {
            double[] complexWindow1DValues = new double[maxResolution];

            for(int pixel = 0; pixel != maxResolution; pixel++)
            {
                //x = a + (p/width) * (b - a)
                complexWindow1DValues[pixel] = minComplex + ((double)pixel / maxResolution) * (maxComplex - minComplex);
            }

            return complexWindow1DValues;
        }

        public static void getWindowComplexArray()
        {
            int width = _windowSize.Width,
                height = _windowSize.Height;

            _windowValues = new Complex[width * height];

            for(int realIndex = 0; realIndex < width; realIndex++)
            {
                for(int imgIndex = 0; imgIndex < height; imgIndex++)
                {
                    _windowValues[realIndex + imgIndex * width] = new Complex(_windowReals[realIndex], 
                        _windowImaginaries[imgIndex]);
                }
            }
        }

        /// <summary>
        /// Generates an array of colors of size = _maxIter + 1. It depends on the _colorPalette.
        /// </summary>
        public static void getColorRange()
        {
            // Array of colors, based on _colorPalette.
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

        /// <summary>
        /// Evaluate quadratic complex function of the form f(z) = z^2 + c. Where c is the variable _constant.
        /// </summary>
        /// <param name="z">Input z complex number to the function f(z).</param>
        /// <returns>Returns the evaluation of f(z).</returns>
        public static Complex computeQuadraticFunction(Complex z)
        {
            Complex f = z * z + _constant;
            return f;
        }

        /// <summary>
        /// Evaluates whether the complex number z is likely to belong to the filledn-in Julia set K(f).
        /// </summary>
        /// <param name="z">Complex number z.</param>
        /// <returns>Returns 0 if z is likely to belong to K(f). It returns _maxiter - computed iterations otherwise.</returns>
        public static int isInFilledJulia(Complex z)
        {
            Complex f = z;

            // Loop over iterations.
            for (int iteration = 0; iteration < _maxIter; iteration++)
            {
                // Evaluate f(z) = z^2 + c
                f = computeQuadraticFunction(f);

                // Evaluate theorem condition |f^n(z_0)| > R
                if (f.Magnitude > _radius)
                {
                    return _maxIter - iteration; // is not in the filled-in Julia, is in Basin
                }
            }

            return 0; // is in filled-in Julia
        }

        /// <summary>
        /// Paints the representation of the filled-in Julia set K(f) to each frame of _pixelsInJulia.
        /// The values represented in each frame are given by the parameters min and max.
        /// </summary>
        /// <param name="min">Minimum complex value of the frame.</param>
        /// <param name="max">Maximum complex value of the frame.</param>
        public static void screen2ComplexWindow(Complex min, Complex max)
        {
            //double initPhase = _constant.Phase, //Initial phase to be displayed, given by the user in _constant.
            //    currentPhase = initPhase, //Current phase for which the representation is being computed.
            //    constantMagnitude = _constant.Magnitude; //Magnitude of _constant.

            int width = _windowSize.Width, //Pixel window width.
                height = _windowSize.Height, //Pixel window height.
                totalFrames = _totalFrames,//1, //Total number of frames, depends on _stepPhase.
                colorIndex = 0; //Index of the color in _colorRange.

            Bitmap pixelsInJulia = new Bitmap(width, height); //Bitmap image representing the window frame.
            
            _windowReals = pixel2Complex(min.Real, max.Real, width); //Get the real numbers of the window frame.
            _windowImaginaries = pixel2Complex(min.Imaginary, max.Imaginary, height); //Get the imaginary numbers of the window frame.
            getWindowComplexArray(); //Get an array of the complex values combinations of reals and imaginaries.
            getColorRange(); //Get the range of colors.            

            // Get number of total frames to be displayed. If step is set to 0, only the starting frame will be displayed.
            //if (_stepPhase != 0)
            //{
            //    totalFrames = (int)Math.Floor(_2PI / _stepPhase);
            //}
            //else
            //{
            //    totalFrames = 1;
            //}

            _pixelsInJulia = new Bitmap[totalFrames];

            // Loop over frames
            for (int frame = 0; frame < totalFrames; frame++)
            {
                //Update _constant.
                _constant = _constants[frame];

                // Loop over reals
                for (int realIndex = 0; realIndex < width; realIndex++)
                {
                    // Loop over imaginaries
                    for (int imgIndex = 0; imgIndex < height; imgIndex++)
                    {
                        // Check whether the current pixel/complex number belongs to the filled-in Julia and get its color index of _colorRange.
                        //colorIndex = isInFilledJulia(new Complex(_windowReals[realIndex], _windowImaginaries[imgIndex]));
                        colorIndex = isInFilledJulia(_windowValues[realIndex + imgIndex * width]);
                        // Set pixel color.
                        pixelsInJulia.SetPixel(realIndex, imgIndex, _colorRange[colorIndex]);
                    }
                }
                // Set frame.
                _pixelsInJulia[frame] = (Bitmap)pixelsInJulia.Clone();
                // Increase phase of _constant.
                //currentPhase += _stepPhase;
                // Update _constant.
                //_constant = new Complex(constantMagnitude * Math.Cos(currentPhase),
                //    constantMagnitude * Math.Sin(currentPhase));
            }

            _totalFrames = totalFrames;
        }
    }
}