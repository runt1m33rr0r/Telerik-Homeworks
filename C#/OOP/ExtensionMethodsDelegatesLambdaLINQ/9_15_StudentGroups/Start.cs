namespace _9_15_StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        private static void Main()
        {
            var studentsList = new List<Student>()
            {
                new Student("Boiko", "Simeonov", 544919, "0212345678", 1, "boi4eto@abv.bg"),
                new Student("Pesho", "Simeoneov", 304900, "0542345112", 2, "pesh00@gmail.com"),
                new Student("Petyr", "Dimov", 5462106, "0216657591", 4, "petre77@gmail.com"),
                new Student("Todor", "Stoqnov", 344306, "0411291116", 2, "to60@abv.bg"),
                new Student("Georgi", "Iordanov", 148122, "0278287212", 3, "gri6ata10@gmail.com"),
                new Student("Zahari", "Stoqnov", 567455, "0345398712", 4, "zahar12345@abv.bg")
            };

            // Add Marks
            studentsList[0].AddMark(2);
            studentsList[0].AddMark(2);
            studentsList[1].AddMark(6);
            studentsList[1].AddMark(4);
            studentsList[2].AddMark(2);
            studentsList[2].AddMark(3);
            studentsList[3].AddMark(3);
            studentsList[3].AddMark(2);
            studentsList[4].AddMark(5);
            studentsList[4].AddMark(5);
            studentsList[5].AddMark(2);
            studentsList[5].AddMark(3);

            // Task 9 
            var studetnsFromGroup2 = studentsList
                .Where(st => st.GroupNumber == 2)
                .OrderBy(st => st.FirstName)
                .ToList();

            foreach (var student in studetnsFromGroup2)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " group: " + student.GroupNumber);
            }

            Console.WriteLine("------------------------------------------------------");

            // Taks 10
            var secondListofStudentsGroup2 = studentsList.FindStudentsFromSecondGroup();

            foreach (var student in secondListofStudentsGroup2)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " group: " + student.GroupNumber);
            }

            Console.WriteLine("------------------------------------------------------");

            // Task 11
            var extractedStudents = studentsList
                .Where(st => st.Email.Contains("abv.bg"))
                .ToList();

            foreach (var student in extractedStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " email: " + student.Email);
            }

            Console.WriteLine("------------------------------------------------------");

            // Task 12
            var studentFromSofia = studentsList
                .Where(st => st.TelNumber[0] == '0' && st.TelNumber[1] == '2')
                .ToList();

            foreach (var student in studentFromSofia)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " telephone: " + student.TelNumber);
            }

            Console.WriteLine("------------------------------------------------------");

            // Task 13
            var studentsWith6 = studentsList
                .Where(st => st.Marks.Contains(6))
                .ToList();

            var anonymousType = new
            {
                FullName = studentsWith6.Select(st => st.FirstName + " " + st.LastName),
                Marks = studentsWith6.Select(st => st.Marks)
            };

            Console.WriteLine("Students that have at least one excellent mark:");

            foreach (var name in anonymousType.FullName)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("------------------------------------------------------");

            // Task 14
            var weakStudents = studentsList.ExtractStudentsWithBadMark();

            foreach (var student in weakStudents)
            {
                Console.Write(student.FirstName + " " + student.LastName + " marks: ");
                Console.WriteLine(string.Join(", ", student.Marks));
            }

            Console.WriteLine("------------------------------------------------------");

            // Task 15 
            var studentsFrom06 = studentsList
                .Where(st => st.FacNumber.ToString().Substring(4, 2) == "06")
                .Select(st => st.Marks)
                .ToList();

            Console.Write("Marks of students from 2006: ");

            foreach (var marks in studentsFrom06)
            {
                Console.WriteLine(string.Join(", ", marks));
            }

            Console.WriteLine("------------------------------------------------------");

            // Task 18
            var groupedStudents = studentsList.GroupBy(st => st.GroupNumber);

            int i = 1;
            foreach (var students in groupedStudents)
            {
                Console.WriteLine("Group {0}", i);
                foreach (var student in students)
                {
                    if (i == 0)
                    {
                        Console.WriteLine(student.GroupNumber);
                    }

                    Console.WriteLine(student.FirstName + " " + student.LastName);
                }

                Console.WriteLine();
                i++;
            }

            Console.WriteLine("------------------------------------------------------");

            // Task 19
            studentsList.GroupedByGroupNumber();
        }
    }
}