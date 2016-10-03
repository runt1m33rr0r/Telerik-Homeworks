namespace _1_SchoolClasses.People
{
    using Interfaces;
    using System;

    public class Person : INamable
    {
        private string personName;

        public Person(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.personName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name!");
                }

                this.personName = value;
            }
        }
    }
}
