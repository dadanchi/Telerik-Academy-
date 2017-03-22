namespace ChefRefactoring.Models
{
    using System.Collections.Generic;

    using ChefRefactoring.Contracts;
    using ChefRefactoring.Factories;

    public class Chef
    {
        private Factory factory;

        public Chef()
        {
            this.factory = new Factory();
        }

        public Bowl MakeASalad(ICollection<string> vegitables)
        {
            Bowl bowl = this.factory.GetBowl();

            foreach (var vegitable in vegitables)
            {
                this.CookAVegitable(vegitable, bowl);
            }

            return bowl;
        }

        private void Peel(IVegitable vegitable)
        {
            // ...do something
        }

        private void Cut(IVegitable vegitable)
        {
            // ...do something
        }

        private void CookAVegitable(string vegitableName, Bowl bowl)
        {
            var vegitable = this.factory.GetAVegitable(vegitableName);
            this.Peel(vegitable);
            this.Cut(vegitable);
            bowl.Add(vegitable);
        }
    }
}
