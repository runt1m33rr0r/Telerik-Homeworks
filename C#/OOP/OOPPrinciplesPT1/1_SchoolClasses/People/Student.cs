namespace _1_SchoolClasses.People
{
    using System;
    using System.Collections.Generic;
    using Interfaces;

    public class Student : Person, ICommentable
    {
        private static List<int> classNumbers = new List<int>();

        private string studentComment;

        public Student(string name, int classNumber, string comment = null) : base(name)
        {
            this.ClassNumber = classNumber;
            this.Comment = comment;
        }

        public int ClassNumber
        {
            get
            {
                return this.ClassNumber;
            }

            set
            {
                if (this.ClassNumber < 0)
                {
                    throw new ArgumentException("The class number can't be negative!");
                }
                else if (classNumbers.Contains(this.ClassNumber))
                {
                    throw new ArgumentException("There is already such class number!");
                }

                classNumbers.Add(this.ClassNumber);
            }
        }

        public string Comment
        {
            get
            {
                return this.studentComment;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid comment!");
                }

                this.studentComment = value;
            }
        }
    }
}
