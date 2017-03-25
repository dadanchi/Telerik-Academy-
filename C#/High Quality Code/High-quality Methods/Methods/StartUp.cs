namespace Methods
{
    using System;

    using Methods.Enums;
    using Methods.Models;

    public class StartUp
    {
        public static void Main()
        {
            // Test Calculator methods
            var area = Calculator.CalcTriangleArea(3, 4, 5);
            Console.WriteLine(area);

            var digitAsString = Calculator.ConvertDigitToString(5);
            Console.WriteLine(digitAsString);

            var numbers = new int[] { 5, -1, 3, 2, 14, 2, 3 };

            var maxNumber = Calculator.FindMax(numbers);
            Console.WriteLine(maxNumber);

            var pointAX = 3;
            var pointAY = -1;
            var pointBX = 3;
            var pointBY = 2.5;

            bool isHorizontal = pointAY == pointBY;
            bool isVertical = pointAX == pointBX;

            Console.WriteLine("Horizontal? " + isHorizontal);
            Console.WriteLine("Vertical? " + isVertical);

            var distance = Calculator.CalcDistance(pointAX, pointAY, pointBX, pointBY);
            Console.WriteLine(distance);

            // Test Printer methods
            Printer.PrintAsNumber(1.3, FormatType.FixedPoint);
            Printer.PrintAsNumber(0.75, FormatType.Percent);
            Printer.PrintAsNumber(2.30, FormatType.FloatRight);
            
            // Test Studdent methods
            var peter = new Student("Peter", "Ivanov", new DateTime(1997, 10, 03), "From Sofia");
            var stella = new Student("Stella", "Markova", new DateTime(1993, 11, 01), "From Vidin, gamer, high results");

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
