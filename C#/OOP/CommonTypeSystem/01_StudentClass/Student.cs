namespace _01_02_03_StudentClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Enums;

    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string ssn;
        private string address;
        private string phone;
        private string email;
        private string course;
        private Speciality studentSpeciality;
        private University studentUniversity;
        private Faculty studentFaculty;

        public Student(
            string firstName, 
            string middleName, 
            string lastName,
            string ssn, 
            string address,
            string phone,
            string email,
            string course,
            Speciality spec,
            University uni,
            Faculty studFac)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SsnNumber = ssn;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.Course = course;
            this.StudentSpeciality = spec;
            this.StudentUniversity = uni;
            this.StudentFaculty = studFac;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The first name can not be empty!");
                }

                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The middle name can not be empty!");
                }

                this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The last name can not be empty!");
                }

                this.lastName = value;
            }
        }

        public string SsnNumber
        {
            get
            {
                return this.ssn;
            }

            set
            {
                if (value.Length != 9)
                {
                    throw new ArgumentException("The SSN number must be exactly 9 digits!");
                }

                this.ssn = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The address can not be empty!");
                }

                this.address = value;
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }

            set
            {
                if (value.Length != 10)
                {
                    throw new ArgumentException("The phone must length must be exactly 10 symbols!");
                }

                this.phone = value;
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
                if (string.IsNullOrEmpty(value) || value.Contains("@") == false || value.Contains(".") == false)
                {
                    throw new ArgumentException("Email not valid!");
                }

                this.email = value;
            }
        }

        public string Course
        {
            get
            {
                return this.course;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The course can not be empty!");
                }

                this.course = value;
            }
        }

        public Speciality StudentSpeciality
        {
            get
            {
                return this.studentSpeciality;
            }

            set
            {
                this.studentSpeciality = value;
            }
        }

        public University StudentUniversity
        {
            get
            {
                return this.studentUniversity;
            }

            set
            {
                this.studentUniversity = value;
            }
        }

        public Faculty StudentFaculty
        {
            get
            {
                return this.studentFaculty;
            }

            set
            {
                this.studentFaculty = value;
            }
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return student1.Equals(student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !student1.Equals(student2);
        }

        public override bool Equals(object param)
        {
            Student student = param as Student;

            if (this.Phone == student.Phone)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(string.Format("Student name: {0} {1} {2}\n", this.FirstName, this.MiddleName, this.LastName));
            result.Append(string.Format("SSN: {0}\n", this.SsnNumber));
            result.Append(string.Format("Aaddress: {0}\n", this.Address));
            result.Append(string.Format("Phone number: {0}\n", this.Phone));
            result.Append(string.Format("Email: {0}\n", this.Email));
            result.Append(string.Format("Attended course: {0}\n", this.Course));
            result.Append(string.Format("Speciality: {0}\n", this.StudentSpeciality));
            result.Append(string.Format("University: {0}\n", this.StudentUniversity));
            result.Append(string.Format("Faculty: {0}\n", this.StudentFaculty));

            return result.ToString();
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^
                this.MiddleName.GetHashCode() ^
                this.LastName.GetHashCode() ^
                this.SsnNumber.GetHashCode() ^ 
                this.Address.GetHashCode() ^
                this.Phone.GetHashCode() ^
                this.Email.GetHashCode() ^
                this.Course.GetHashCode() ^
                this.StudentSpeciality.GetHashCode() ^
                this.StudentUniversity.GetHashCode() ^
                this.StudentFaculty.GetHashCode();
        }

        public object Clone()
        {
            return new Student(
               this.FirstName,
               this.MiddleName,
               this.LastName,
               this.SsnNumber,
               this.Address,
               this.Phone,
               this.Email,
               this.Course,
               this.StudentSpeciality,
               this.StudentUniversity,
               this.StudentFaculty);
        }

        public int CompareTo(Student other)
        {
            var stringCompare = new List<Student> { this, other };
            Student sorted;

            if (this.FirstName != other.FirstName && this.MiddleName != other.MiddleName && this.LastName != other.LastName)
            {
                sorted = stringCompare
                    .OrderBy(x => x.FirstName)
                    .ThenBy(x => x.MiddleName)
                    .ThenBy(x => x.LastName)
                    .ToList()
                    .FirstOrDefault();

                if (sorted == this)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            else if (this.SsnNumber != other.SsnNumber)
            {
                sorted = stringCompare
                    .OrderBy(x => x.SsnNumber)
                    .ToList()
                    .FirstOrDefault();

                if (this.SsnNumber == sorted.SsnNumber)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
