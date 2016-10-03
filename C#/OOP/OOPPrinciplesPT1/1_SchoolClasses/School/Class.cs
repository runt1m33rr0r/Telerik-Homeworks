namespace _1_SchoolClasses.School
{
    using System;
    using System.Collections.Generic;
    using People;

    public class Class
    {
        private static List<string> identifiers = new List<string>();
        private string classIdentifier;

        public Class(string identifier, List<Teacher> teachers, List<Student> students)
        {
            this.Identifier = identifier;
            this.Teachers = teachers;
            this.Students = students;
        }

        public string Identifier
        {
            get
            {
                return this.classIdentifier;
            }

            set
            {
                if (identifiers.Contains(value))
                {
                    throw new ArgumentException("There is already such identifier!");
                }

                identifiers.Add(value);
                this.classIdentifier = value;
            }
        }

        public List<Teacher> Teachers { get; set; }

        public List<Student> Students { get; set; }
    }
}
