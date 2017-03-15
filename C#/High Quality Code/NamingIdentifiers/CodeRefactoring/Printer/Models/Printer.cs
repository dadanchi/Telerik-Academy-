namespace Printers.Models
{
    using System;

    public class Printer
    {
        public void PrintAStatement(bool statement)
        {
            string statementAsString = statement.ToString();
            Console.WriteLine(statementAsString);
        }
    }
}
