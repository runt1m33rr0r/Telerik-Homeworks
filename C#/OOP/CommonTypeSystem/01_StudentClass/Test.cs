namespace _01_02_03_StudentClass
{
    using System;
    using Enums;

    public class StudentClassTest
    {
        public static void Main()
        {
            Student firstStudent = new Student(
                "Petar",
                "Petrov",
                "Petrov",
                "111001111",
                "some address",
                "0898741432",
                "mail@abv.bg",
                "some course",
                Speciality.Construction,
                University.UniversityOfSofia,
                Faculty.Sports);

            Student secondStudent = new Student(
                "Petar",
                "Petrov",
                "Petrov",
                "111001111",
                "some address",
                "0898741432",
                "mail@abv.bg",
                "some course",
                Speciality.Construction,
                University.UniversityOfSofia,
                Faculty.Sports);

            var equalStudents = firstStudent == secondStudent;
            var hashCode = firstStudent.GetHashCode();

            Console.WriteLine("First and second student equal: {0}\n", equalStudents);

            Console.WriteLine("Hash code of first student: {0}\n", hashCode);

            Console.WriteLine(firstStudent);

            var firstStudentCloning = firstStudent.Clone() as Student;
            firstStudentCloning.LastName = "Todorov";
            firstStudentCloning.StudentFaculty = Faculty.Medicine;

            Console.WriteLine(firstStudentCloning);

            Console.WriteLine("Comparison: {0}\n", firstStudent.CompareTo(secondStudent));
        }
    }
}
