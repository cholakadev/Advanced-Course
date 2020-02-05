namespace SpaceStationRecruitment
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class SpaceStation
    {
        private List<Astronaut> data;

        public SpaceStation(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;

            data = new List<Astronaut>();
        }
        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count => data.Count;

        public void Add(Astronaut astronaut)
        {
            if (!this.data.Any(x => x.Name == astronaut.Name) && data.Count < Capacity)
            {
                data.Add(astronaut);
            }
        }

        public bool Remove(string name)
        {
            Astronaut nameToRemove = this.data.Find(x => x.Name == name);

            if (this.data.Any(x => x.Name == name))
            {
                data.Remove(nameToRemove);
                return true;
            }

            return false;
        }

        public Astronaut GetOldestAstronaut()
        {
            //Astronaut oldestAstronaut = data[0];

            //for (int i = 0; i < data.Count; i++)
            //{
            //    if(data[i].Age > oldestAstronaut.Age)
            //    {
            //        oldestAstronaut = data[i];
            //    }
            //}

            //return oldestAstronaut;

            return this.data.OrderByDescending(x => x.Age).FirstOrDefault();    
        }

        public Astronaut GetAstronaut(string name)
        {
            Astronaut astronaut = this.data.Find(x => x.Name == name);

            return astronaut;
        }

        public string Report()
        {
            StringBuilder newSB = new StringBuilder();

            newSB.AppendLine($"Astronauts working at Space Station {this.Name}:");

            for (int i = 0; i < data.Count; i++)
            {
                newSB.AppendLine(data[i].ToString());
            }

            return newSB.ToString().Trim();
        }
    }
}
