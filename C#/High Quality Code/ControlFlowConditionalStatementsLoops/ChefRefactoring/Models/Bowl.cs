namespace ChefRefactoring.Models
{
    using System.Collections.Generic;
    using System.Text;

    using ChefRefactoring.Contracts;

    public class Bowl
    {
        private ICollection<IVegitable> products;

        public Bowl()
        {
            this.products = new List<IVegitable>();
        }

        public void Add(IVegitable vegitable)
        {
            this.products.Add(vegitable);
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            foreach (var product in this.products)
            {
                result.AppendLine(product.GetType().Name);
            }

           return result.ToString();
        }
    }
}
