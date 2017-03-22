namespace PrintingStatisticsRefactoring.StatisticsMethods
{
    using PrintingStatisticsRefactoring.Writer;

    public class StatisticMethods
    {
        public static double FindMaximumValue(double[] collection)
        {
            double maxValue = double.MinValue;
            var length = collection.Length;

            for (int i = 0; i < length; i++)
            {
                var currentValue = collection[i];

                if (currentValue > maxValue)
                {
                    maxValue = currentValue;
                }
            }

            return maxValue;
        }

        public static double FindMinimalValue(double[] collection)
        {
            var minValue = double.MaxValue;
            var length = collection.Length;

            for (int i = 0; i < length; i++)
            {
                var currentValue = collection[i];

                if (currentValue < minValue)
                {
                    minValue = currentValue;
                }
            }

            return minValue;
        }

        public static double FindAverage(double[] collection)
        {
            var length = collection.Length;
            double sum = 0;

            for (int i = 0; i < length; i++)
            {
                var currentValue = collection[i];

                sum += currentValue;
            }

            double average = sum / length;

            return average;
        }

        public static void PrintStatistics(double[] statistics)
        {
            var maxValue = FindMaximumValue(statistics);
            ConsoleWriter.Print(maxValue);

            var minValue = FindMinimalValue(statistics);
            ConsoleWriter.Print(minValue);

            var average = FindAverage(statistics);
            ConsoleWriter.Print(average);
        }
    }
}