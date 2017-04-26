namespace CompareSimpleMaths
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            const int IntegerExample = 1;
            const long LongExample = 1;
            const float FloatExample = 1f;
            const double DoubleExample = 1;
            const decimal DecimalExample = 1m;

            // Implement it once with no point because the fisrt time it takes longer
            var firstTryResults = PerformFullComparison(FloatExample);

            var intResults = PerformFullComparison(IntegerExample);
            var longResults = PerformFullComparison(LongExample);
            var floatResults = PerformFullComparison(FloatExample);
            var doubleResults = PerformFullComparison(DoubleExample);
            var decimalResults = PerformFullComparison(DecimalExample);

            Print(intResults, "int");
            Print(longResults, "long");
            Print(floatResults, "float");
            Print(doubleResults, "double");
            Print(decimalResults, "decimal");
        }

        private static double CompareAdding<T>(T number)
        {
            var results = new List<TimeSpan>();
            var timeCounter = new Stopwatch();

            for (int j = 0; j < 10; j++)
            {
                timeCounter.Start();

                for (int i = 0; i < 10000; i++)
                {
                    number += (dynamic)i;
                }

                timeCounter.Stop();
                results.Add(timeCounter.Elapsed);

                timeCounter.Reset();
            }

            return results.Average(ts => ts.Milliseconds);
        }

        private static double CompareSubstract<T>(T number)
        {
            var results = new List<TimeSpan>();
            var timeCounter = new Stopwatch();

            for (int j = 0; j < 10; j++)
            {
                timeCounter.Start();

                for (int i = 0; i < 10000; i++)
                {
                    number -= (dynamic)i;
                }

                timeCounter.Stop();
                results.Add(timeCounter.Elapsed);

                timeCounter.Reset();
            }

            return results.Average(ts => ts.Milliseconds);
        }

        private static double CompareIncrementation(dynamic number)
        {
            var results = new List<TimeSpan>();
            var timeCounter = new Stopwatch();

            for (int j = 0; j < 10; j++)
            {
                timeCounter.Start();

                for (int i = 0; i < 10000; i++)
                {
                    number++;
                }

                timeCounter.Stop();
                results.Add(timeCounter.Elapsed);

                timeCounter.Reset();
            }

            return results.Average(ts => ts.Milliseconds);
        }

        private static double CompareMultiplication<T>(T number)
        {
            var results = new List<TimeSpan>();
            var timeCounter = new Stopwatch();

            for (int j = 0; j < 10; j++)
            {
                timeCounter.Start();

                for (int i = 0; i < 10000; i++)
                {
                    number *= (dynamic)i;
                }

                timeCounter.Stop();

                results.Add(timeCounter.Elapsed);

                timeCounter.Reset();
            }

            return results.Average(ts => ts.Milliseconds);
        }

        private static double CompareDivision<T>(T number)
        {
            var results = new List<TimeSpan>();
            var timeCounter = new Stopwatch();

            for (int j = 0; j < 10; j++)
            {
                timeCounter.Start();

                for (int i = 1; i < 10000; i++)
                {
                    number /= (dynamic)i;
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
            results.Add(CompareAdding(number));
            results.Add(CompareSubstract(number));
            results.Add(CompareIncrementation(number));
            results.Add(CompareMultiplication(number));
            results.Add(CompareDivision(number));

            return results;
        }

        private static void Print(IList<double> collection, string type)
        {
            Console.WriteLine($"The average time for executing the adding for the {type} type is: {collection[0]}s");
            Console.WriteLine($"The average time for executing the substracting for the {type} type is: {collection[1]}s");
            Console.WriteLine($"The average time for executing the incremention for the {type} type is: {collection[2]}s");
            Console.WriteLine($"The average time for executing the multiplication for the {type} type is: {collection[3]}s");
            Console.WriteLine($"The average time for executing the division for the {type} type is: {collection[4]}s");
            Console.WriteLine();
        }
    }
}

