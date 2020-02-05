namespace HealthyHeaven
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Restaurant
    {
        private List<Salad> data;

        public Restaurant(string name)
        {
            this.Name = name;
            data = new List<Salad>();
        }

        public string Name { get; set; }

        public void Add(Salad salad)
        {
            data.Add(salad);
        }

        public bool Buy(string name)
        {
            if (this.data.Any(x => x.Name == name))
            {
                Salad saladToRemove = this.data.Find(x => x.Name == name);
                this.data.Remove(saladToRemove);
                return true;
            }

            return false;
        }

        public Salad GetHealthiestSalad()
        {
            Salad healthiestSalad = data[0];

            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].GetTotalCalories() < healthiestSalad.GetTotalCalories())
                {
                    healthiestSalad = data[i];
                }
            }

            return healthiestSalad;
        }

        public string GenerateMenu()
        {
            StringBuilder menu = new StringBuilder();

            menu.AppendLine($"{this.Name} have {data.Count} salads:");

            for (int i = 0; i < data.Count; i++)
            {
                menu.AppendLine(data[i].ToString());
            }

            return menu.ToString().Trim();
        }
    }
}
