namespace Abstraction
{
    using System;
    using System.Text;

    using Contracts;

    public class Rectangle : Figure, IRectangle
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be positive.");
                }

                this.height = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width must be positive.");
                }

                this.width = value;
            }
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);

            return perimeter;
        }

        public override double CalculateSurface()
        {
            double surface = this.Width * this.Height;

            return surface;
        }

        public override string ToString()
        {
            double surface = this.CalculateSurface();
            double perimeter = this.CalculatePerimeter();
            var result = new StringBuilder();
            result.AppendFormat("I am a rectangle. My perimeter is {0:f2}. My surface is {1:f2}.", perimeter, surface);

            return result.ToString();
        }
    }
}
