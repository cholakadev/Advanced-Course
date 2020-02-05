using DefiningClasses;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> familyMembers = new List<Person>();

        public void AddMember(Person member)
        {
            this.familyMembers.Add(member);
        }

        public Person GetOldestMember()
        {
            return familyMembers.OrderByDescending(x => x.Age).FirstOrDefault();
        }

        public List<Person> AllOverThirty()
        {
            return this.familyMembers.Where(x => x.Age > 30).ToList();
        }
    }
}
