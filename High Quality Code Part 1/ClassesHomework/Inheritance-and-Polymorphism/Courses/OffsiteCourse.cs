﻿namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;
    using System.Text;
    using Courses;
    using Interfaces;

    public class OffsiteCourse : Course, ICourse
    {
        public OffsiteCourse(string name)
            : base(name)
        {
        }

        public OffsiteCourse(string courseName, string teacherName)
            : base(courseName, teacherName)
        {
        }

        public OffsiteCourse(string courseName, string teacherName, IList<string> students)
            : base(courseName, teacherName, students)
        {
        }

        public string Town { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());

            if (this.Town != null)
            {
                result.Append("; Town = ");
                result.Append(this.Town);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}