using System;
using System.Collections.Generic;
using System.Linq;

namespace ComparingObjects
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] command = Console.ReadLine()
                .Split(" ");

            List<Person> myList = new List<Person>();

            while(command[0] != "END")
            {
                var name = command[0];
                var age = int.Parse(command[1]);
                var town = command[2];

                Person person = new Person(name, age, town);

                myList.Add(person);

                command = Console.ReadLine()
                    .Split(" ");
            }

            int nPerson = int.Parse(Console.ReadLine());

            Person targetPerson = myList[nPerson - 1];

            int matches = 0;

            foreach (var person in myList)
            {
                if (person.CompareTo(targetPerson) == 0 && !person.Equals(targetPerson))
                {
                    matches+=2;
                }
            }

            if (matches == 0)
            {
                Console.WriteLine("No matches!");
            }

            else
            {
                Console.WriteLine($"{matches} {myList.Count - matches} {myList.Count}");
            }
        }
    }
}
