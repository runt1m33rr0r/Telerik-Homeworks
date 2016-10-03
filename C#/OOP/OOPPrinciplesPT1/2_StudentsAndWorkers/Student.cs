namespace _2_StudentsAndWorkers
{
    using System;

    public class Student : Human
    {
        private double studentGrade;

        public Student(string firstName, string lastName, double grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public double Grade
        {
            get
            {
                return this.studentGrade;
            }
            set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentException("Grade must be between 2 and 6!");
                }

                this.studentGrade = value;
            }
        }
    }
}
