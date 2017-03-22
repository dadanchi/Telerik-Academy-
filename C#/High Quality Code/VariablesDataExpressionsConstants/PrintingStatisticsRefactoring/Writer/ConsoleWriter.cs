namespace PrintingStatisticsRefactoring.Writer
{
    using System;

    public static class ConsoleWriter
    {
        public static void Print<T>(T valueForPrinting)
        {
            Console.WriteLine(valueForPrinting);
        }
    }
}
