namespace Printers
{
    using Printers.Models;

    public class StartUp
    {
        public static void Main()
        {
            var printer = new Printer();
            printer.PrintAStatement(true);
        }
    }
}
