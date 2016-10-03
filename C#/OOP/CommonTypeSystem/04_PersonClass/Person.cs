namespace _04_PersonClass
{
    using System;
    using System.Text;

    public class Person
    {
        private string personName;
        private int? age;

        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
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
                    throw new ArgumentException("The name can not be empty!");
                }

                this.personName = value;
            }
        }

        public int? Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age can not be negative!");
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(string.Format("Person's name: {0}", this.Name));

            if (this.Age == null)
            {
                result.Append(string.Format("Age: not specified"));
            }
            else
            {
                result.Append(string.Format("Age: {0}", this.Age));
            }

            return result.ToString();
        }
    }
}
