namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public abstract class Animal : ISound
    {
        private int age;
        private string name;

        public Animal(int age, string name, Sex sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public Sex Sex { get; set; }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Age can not be negative number!");
                }

                this.age = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(value.Length < 2)
                {
                    throw new ArgumentException("Wrong name validation!");
                }

                this.name = value;
            }
        }

        public static double AverageAge(IEnumerable<Animal> animals)
        {
            return animals.Average(x => x.Age);
        }
        public abstract void MakeSound();

        public override string ToString()
        {
            return string.Format("{0} is {1} and is {2} years old.", this.Name, this.Sex, this.Age);
        }
    }
}
