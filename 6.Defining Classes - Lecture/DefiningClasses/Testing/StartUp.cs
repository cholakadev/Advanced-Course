using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < num; i++)
            {
                var person = Console.ReadLine().Split();

                var name = person[0];
                var age = int.Parse(person[1]);
                Person member = new Person(name, age);

                family.AddMember(member);
            }

            var AllOverThirty = family
                .AllOverThirty()
                .OrderBy(x => x.Name)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, AllOverThirty));
        }
    }
}
