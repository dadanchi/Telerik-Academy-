namespace Abstraction
{
    using System;
    using System.Text;

    using Contracts;
    
    public class Circle : Figure, ICircle
    {
        private double radius;
        
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Radius must be positive.");
                }
                
                this.radius = value;
            }
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;

            return perimeter;
        }

        public override double CalculateSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;

            return surface;
        }

        public override string ToString()
        {
            var perimeter = this.CalculatePerimeter();
            var surface = this.CalculateSurface();
            var result = new StringBuilder();
            result.AppendFormat("I am a circle. My perimeter is {0:f2}. My surface is {0:f2}.", perimeter, surface);

            return result.ToString();
        }
    }
}
