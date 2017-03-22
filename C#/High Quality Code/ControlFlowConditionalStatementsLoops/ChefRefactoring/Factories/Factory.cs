namespace ChefRefactoring.Factories
{
    using System;

    using ChefRefactoring.Contracts;
    using ChefRefactoring.Models;

    public class Factory
    {
        public IVegitable GetAVegitable(string vegitable)
        {
            switch (vegitable)
            {
                case "Carrot":
                    var newCarrot = new Carrot();
                    return newCarrot;

                case "Potato":
                    var newPotato = new Potato();
                    return newPotato;

                default:
                    throw new ArgumentException("There is no such vegitable available for creating");
            }
        }

        public Bowl GetBowl()
        {
            var newBowl = new Bowl();
            return newBowl;
        }
    }
}
