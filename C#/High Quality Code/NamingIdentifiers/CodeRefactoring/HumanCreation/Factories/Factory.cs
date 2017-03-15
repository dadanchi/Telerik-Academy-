namespace HumanCreation.Factories
{
    using System;

    using HumanCreation.Enums;
    using HumanCreation.Models;

    public static class Factory
    {
        public static Human CreateAHuman(int age)
        {
            var newHuman = new Human();
            newHuman.Age = age;

            if (age % 2 == 0)
            {
                newHuman.Name = "Gosho";
                newHuman.Gender = Gender.Male;
            }
            else
            {
                newHuman.Name = "Goshka";
                newHuman.Gender = Gender.Female;
            }

            Console.WriteLine($"{newHuman.Name} was created!");

            return newHuman;
        }
    }
}
