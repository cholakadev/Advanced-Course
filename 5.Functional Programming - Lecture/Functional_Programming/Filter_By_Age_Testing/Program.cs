using System;
using System.Collections.Generic;
using System.Linq;

namespace Filter_By_Age_Testing
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(", ");

                var name = input[0];
                var age = int.Parse(input[1]);

                var person = new Person(name, age);

                people.Add(person);
            }

            var condition = Console.ReadLine();
            var conditionAge = int.Parse(Console.ReadLine());
            var format = Console.ReadLine().Split();

            Func<Person, bool> predicate = p => true;

            if (condition.ToLower() == "younger")
            {
                predicate = p => p.Age < conditionAge;
            }
            else if (condition.ToLower() == "older")
            {
                predicate = p => p.Age >= conditionAge;
            }

            var filteredPeople = people.Where(predicate);

            foreach (var person in filteredPeople)
            {
                if (format.Length == 2)
                {
                    Console.WriteLine($"{person.Name} - {person.Age}");
                }
                else if (format[0].ToLower() == "name")
                {
                    Console.WriteLine($"{person.Name}");
                }
                else if (format[0].ToLower() == "age")
                {
                    Console.WriteLine($"{person.Age}");
                }
            }
        }
    }
}
