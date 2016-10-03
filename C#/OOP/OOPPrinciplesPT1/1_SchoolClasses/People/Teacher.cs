namespace _1_SchoolClasses.People
{
    using System.Collections.Generic;
    using Interfaces;
    using School;
    using System;

    public class Teacher : Person, ICommentable
    {
        private string teacherComment;

        public Teacher(string name, List<Discipline> disciplines, string comment) : base(name)
        {
            this.Disciplines = disciplines;
            this.Comment = comment;
        }

        public List<Discipline> Disciplines { get; set; }

        public string Comment
        {
            get
            {
                return this.teacherComment;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid comment!");
                }

                this.teacherComment = value;
            }
        }
    }
}
