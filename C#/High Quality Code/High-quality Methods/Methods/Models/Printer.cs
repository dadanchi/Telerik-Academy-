namespace Methods.Models
{
    using System;

    using Enums;

    public static class Printer
    {
        public static void PrintAsNumber(object number, FormatType format)
        {
            switch (format)
            {
                case FormatType.FixedPoint:
                    Console.WriteLine("{0:f2}", number);
                    break;
                case FormatType.Percent:
                    Console.WriteLine("{0:p0}", number);
                    break;
                case FormatType.FloatRight:
                    Console.WriteLine("{0,8}", number);
                    break;
                default:
                    throw new ArgumentException("Invalid format");
            }
        }
    }
}
