namespace ChefRefactoring
{
    using System;
    using System.Collections.Generic;

    using ChefRefactoring.Models;

    public class StartUp
    {
        public static void Main()
        {
            var chefManchev = new Chef();
            var saladProducts = new List<string>
            {
                "Potato",
                "Potato",
                "Carrot"
                
                // Dat salad doe
            };

            var mySalad = chefManchev.MakeASalad(saladProducts);

            Console.WriteLine(mySalad);
        }
    }
}
