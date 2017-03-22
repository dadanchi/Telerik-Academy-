namespace PrintingStatisticsRefactoring
{
    using PrintingStatisticsRefactoring.StatisticsMethods;

    public class StartUp
    {
        public static void Main()
        {
            double[] testStatistics = new double[] { 1.2, 12, 0.5, -23.2, 42.9 };

            StatisticMethods.PrintStatistics(testStatistics);
        }
    }
}
