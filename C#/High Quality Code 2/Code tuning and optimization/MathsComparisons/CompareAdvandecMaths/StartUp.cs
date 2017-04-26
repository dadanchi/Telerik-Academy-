namespace CompareAdvancedMaths
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            const float FloatExample = 1f;
            const double DoubleExample = 1;
            const decimal DecimalExample = 1m;

            // Implement it once with no point because the fisrt time it takes longer
            var firstTryResults = PerformFullComparison(FloatExample);

            var floatResults = PerformFullComparison(FloatExample);
            var doubleResults = PerformFullComparison(DoubleExample);
            var decimalResults = PerformFullComparison(DecimalExample);

            Print(floatResults, "float");
            Print(doubleResults, "double");
            Print(decimalResults, "decimal");
        }

        private static double CompareSqrt<T>(T number)
        {
            var results = new List<TimeSpan>();
            var timeCounter = new Stopwatch();
            double doubleNumber = 1;

            for (int i = 0; i < 10; i++)
            {
                timeCounter.Start();

                for (int j = 0; j < 10000; j++)
                {
                    doubleNumber = Math.Sqrt((double)(dynamic)number);
                }

                timeCounter.Stop();
                results.Add(timeCounter.Elapsed);

                timeCounter.Reset();
            }

            return results.Average(ts => ts.Milliseconds);
        }

        private static double CompareNaturalLogarithm<T>(T number)
        {
            var results = new List<TimeSpan>();
            var timeCounter = new Stopwatch();
            double doubleNumber = 1;

            for (int i = 0; i < 10; i++)
            {
                timeCounter.Start();

                for (int j = 0; j < 10000; j++)
                {
                    doubleNumber = Math.Log((double)(dynamic)number);
                }

                timeCounter.Stop();
                results.Add(timeCounter.Elapsed);

                timeCounter.Reset();
            }

            return results.Average(ts => ts.Milliseconds);
        }

        private static double CompareSinus<T>(T number)
        {
            var results = new List<TimeSpan>();
            var timeCounter = new Stopwatch();
            double doubleNumber = 1;

            for (int i = 0; i < 10; i++)
            {
                timeCounter.Start();

                for (int j = 0; j < 10000; j++)
                {
                    doubleNumber = Math.Sin((double)(dynamic)number);
                }

                timeCounter.Stop();
                results.Add(timeCounter.Elapsed);

                timeCounter.Reset();
            }

            return results.Average(ts => ts.Milliseconds);
        }

        private static List<double> PerformFullComparison<T>(T number)
        {
            var results = new List<double>();
            results.Add(CompareSqrt(number));
            results.Add(CompareNaturalLogarithm(number));
            results.Add(CompareSinus(number));

            return results;
        }

        private static void Print(IList<double> collection, string type)
        {
            Console.WriteLine($"The average time for executing the Math.Sqrt for the {type} type is: {collection[0]}s");
            Console.WriteLine($"The average time for executing the Math.Log for the {type} type is: {collection[1]}s");
            Console.WriteLine($"The average time for executing the Math.Sin for the {type} type is: {collection[2]}s");
            Console.WriteLine();
        }
    }
}
