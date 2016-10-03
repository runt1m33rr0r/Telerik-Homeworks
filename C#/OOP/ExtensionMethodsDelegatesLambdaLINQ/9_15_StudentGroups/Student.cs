namespace _9_15_StudentGroups
{
    using System.Collections.Generic;

    public class Student
    {
        private string firstName;
        private string lastName;
        private int facNumber;
        private string telNumber;
        private string email;
        private int groupNumber;
        private List<int> marks = new List<int>();

        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Student(string firstName, string lastName, int facNumber, string telNumber, int groupNumber, string email) : this(firstName, lastName)
        {
            this.FacNumber = facNumber;
            this.TelNumber = telNumber;
            this.GroupNumber = groupNumber;
            this.Email = email;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                this.lastName = value;
            }
        }

        public int FacNumber
        {
            get
            {
                return this.facNumber;
            }

            private set
            {
                this.facNumber = value;
            }
        }

        public string TelNumber
        {
            get
            {
                return this.telNumber;
            }

            set
            {
                this.telNumber = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                this.email = value;
            }
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }

            set
            {
                this.groupNumber = value;
            }
        }

        public List<int> Marks
        {
            get
            {
                return this.marks;
            }
        }

        public void AddMark(int mark)
        {
            this.marks.Add(mark);
        }
    }
}
