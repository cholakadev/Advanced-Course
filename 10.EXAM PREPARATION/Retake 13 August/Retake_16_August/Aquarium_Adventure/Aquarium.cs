namespace AquariumAdventure
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class Aquarium
    {
        private List<Fish> fishInPool;

        public Aquarium(string name, int capacity, int size)
        {
            fishInPool = new List<Fish>();
            this.Name = name;
            this.Capacity = capacity;
            this.Size = size;
        }

        public string Name { get; set; }

        public int Capacity { get; }

        public int Size { get; set; }

        private int Count => fishInPool.Count;

        public void Add(Fish fish)
        {
            if (!this.fishInPool.Any(x => x.Name == fish.Name) && Capacity > Count)
            {
                this.fishInPool.Add(fish);
            }
        }

        public bool Remove(string name)
        {
            if (this.fishInPool.Any(x => x.Name == name))
            {
                Fish fishToRemove = this.fishInPool.Find(x => x.Name == name);
                fishInPool.Remove(fishToRemove);
                return true;
            }

            return false;
        }

        public Fish FindFish(string name)
        {
            if (this.fishInPool.Any(x => x.Name == name))
            {
                Fish fish = this.fishInPool.Find(x => x.Name == name);
                return fish;
            }

            return null;
        }

        public string Report()
        {
            StringBuilder newSB = new StringBuilder();

            newSB.AppendLine($"Aquarium: {this.Name} ^ Size: {this.Size}");

            for (int i = 0; i < this.fishInPool.Count; i++)
            {
                newSB.AppendLine($"{fishInPool[i].ToString()}");
            }

            return newSB.ToString().Trim();
        }
    }
}
