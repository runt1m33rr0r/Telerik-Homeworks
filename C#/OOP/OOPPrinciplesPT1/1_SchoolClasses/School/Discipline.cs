namespace _1_SchoolClasses.School
{
    using System;
    using Interfaces;

    public class Discipline : ICommentable, INamable
    {
        private string disciplineName;
        private int lectures;
        private int exercises;
        private string disciplineComment;

        public Discipline(string name, int numberOfLectures, int numberOfExercises, string comment = null)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
            this.Comment = comment;
        }

        public string Name
        {
            get
            {
                return this.disciplineName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name!");
                }

                this.disciplineName = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.lectures;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The number of lectures can not be a negative number!");
                }

                this.lectures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.exercises;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The number of exercises can not be a negative number!");
                }

                this.exercises = value;
            }
        }

        public string Comment
        {
            get
            {
                return this.disciplineComment;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid comment!");
                }

                this.disciplineComment = value;
            }
        }
    }
}
