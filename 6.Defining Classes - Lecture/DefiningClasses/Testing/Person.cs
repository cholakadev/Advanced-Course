using System;

namespace DefiningClasses
{
    public class Person
    {
        private string name;

        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(string name):this(name, 16)
        {
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length < 2)
                {
                    throw new Exception("Name must contain at least 2 characters");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0 || value > 110)
                {
                    throw new Exception("Age must be between 0 and 110 years.");
                }
                this.age = value;
            }
        }

        public override string ToString()
        {
            return $"{Name} - {Age}";
        }
    }
}
