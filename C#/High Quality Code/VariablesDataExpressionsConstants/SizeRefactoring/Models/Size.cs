namespace SizeRefactoring.Models
{
    using System;

    public class Size
    {
        private double width;
        private double height;

        public Size(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width must have a positive value.");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height must have a positive value.");
                }

                this.height = value;
            }
        }

        public static Size GetRotatedSize(Size size, double angleOfRotation)
        {
            var angleCos = Math.Abs(Math.Cos(angleOfRotation));
            var angleSin = Math.Abs(Math.Sin(angleOfRotation));
            var newWidth = (angleCos * size.width) + (angleSin * size.height);
            var newHeight = (angleSin * size.width) + (angleCos * size.height);

            var rotatedSize = new Size(newWidth, newHeight);

            return rotatedSize;
        }
    }
}
