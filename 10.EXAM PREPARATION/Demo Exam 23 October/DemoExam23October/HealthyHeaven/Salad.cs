namespace HealthyHeaven
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class Salad
    {
        private List<Vegetable> products;

        public Salad(string name)
        {
            this.Name = name;
            this.products = new List<Vegetable>();
        }

        public string Name { get; set; }

        public int Count => products.Count();

        public int GetTotalCalories()
        {
            int sumCalories = 0;

            for (int i = 0; i < products.Count; i++)
            {
                sumCalories += products[i].Calories;
            }

            return sumCalories;
        }

        public int GetProductCount()
        {
            return Count;
        }

        public void Add(Vegetable product)
        {
            products.Add(product);
        }

        public override string ToString()
        {
            StringBuilder newSB = new StringBuilder();

            newSB.AppendLine($"* Salad {this.Name} is {GetTotalCalories()} calories and have {GetProductCount()} products:");

            foreach (var vege in products)
            {
                newSB.AppendLine(vege.ToString());
            }

            return newSB.ToString().Trim();
        }
    }
}
