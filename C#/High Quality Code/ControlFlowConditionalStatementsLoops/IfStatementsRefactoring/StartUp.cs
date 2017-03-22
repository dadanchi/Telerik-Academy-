namespace IfStatementsRefactoring
{
    using System;

    using IfStatementsRefactoring.Models;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            // First part of the code
            Potato potato = new Potato();

            if (potato != null)
            {
                if (potato.isPeeled && !potato.IsRotten)
                {
                    Cook(potato);
                }
            }

            // Second part of the code
            const int MinValueX = 1;
            const int MaxValueX = 50;
            const int MinValueY = 4;
            const int MaxValueY = 23;

            bool hasVisitedCell = false;
            int x = 3;
            int y = 8;

            bool yIsInRange = MaxValueY >= y && MinValueY <= y;
            bool xIsInRange = MaxValueX >= x && MinValueX <= x;

            if (xIsInRange && yIsInRange && !hasVisitedCell)
            {
                VisitCell();
            }
        }

        private static void VisitCell()
        {
            throw new NotImplementedException();
        }

        private static void Cook(Potato potato)
        {
            throw new NotImplementedException();
        }
    }
}
