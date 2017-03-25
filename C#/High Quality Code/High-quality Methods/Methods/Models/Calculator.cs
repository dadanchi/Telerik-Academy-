namespace Methods.Models
{
    using System;

    public static class Calculator
    {
        public static string ConvertDigitToString(int number)
        {
            bool isDigit = number >= 0 && number < 10;

            if (!isDigit)
            {
                throw new ArgumentException("Invalid number!");
            }

            string[] digits =
            {
                "zero",
                "one",
                "two",
                "three",
                "four",
                "five",
                "six",
                "seven",
                "eight",
                "nine"
            };

            var result = digits[number];

            return result;
        }

        public static double CalcTriangleArea(double a, double b, double c)
        {
            bool sidesHavePositiveValue = a > 0 && b > 0 && c > 0;

            if (!sidesHavePositiveValue)
            {
                throw new ArgumentException("Sides should be positive.");
            }

            double semiPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));

            return area;
        }

        public static int FindMax(int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("Invalid input");
            }

            var maxValue = elements[0];

            for (int i = 1; i < elements.Length; i++)
            {
                if (maxValue < elements[i])
                {
                    maxValue = elements[i];
                }
            }

            return maxValue;
        }

        public static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));

            return distance;
        }
    }
}
