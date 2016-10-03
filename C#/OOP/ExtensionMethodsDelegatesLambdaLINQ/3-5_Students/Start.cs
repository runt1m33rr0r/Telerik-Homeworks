namespace _3_5_Students
{
    using System;
    using System.Linq;

    public class Start
    {
        private static void Main()
        {
            var students = new[]
            {
                new Student{ FirstName = "Todor", LastName = "Todorov", Age = 18 },
                new Student{ FirstName = "Patar", LastName = "Stoqnov", Age = 20 },
                new Student{ FirstName = "Georgi", LastName = "Georgiev", Age = 18 },
                new Student{ FirstName = "Boqn", LastName = "Strahilov", Age = 25 },
            };

            // Task 3
            Student[] filtered = StudentMethods.GetFirstBeforeLastNames(students);

            PrintStudents(filtered);

            // Task 4
            Student[] youngStudents = StudentMethods.AgeRange(students);

            PrintStudents(youngStudents);

            // Task 5
            Student[] firstOrderedStudents = students.SortStudentsUsingLambda().ToArray();
            Student[] secondOrderedStudents = students.SortStudentsUsingLinq().ToArray();

            PrintStudents(firstOrderedStudents);
            PrintStudents(secondOrderedStudents);
        }

        private static void PrintStudents(Student[] students)
        {
            foreach (var student in students)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            Console.WriteLine("--------------------------------------------------");
        }
    }
}
