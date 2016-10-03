namespace _9_15_StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Extensions
    {
        public static List<Student> FindStudentsFromSecondGroup(this List<Student> studentsList)
        {
            var studentsFromGroup2 = studentsList
                .Where(st => st.GroupNumber == 2)
                .OrderBy(st => st.FirstName).ToList();

            return studentsFromGroup2;
        }

        public static List<Student> ExtractStudentsWithBadMark(this List<Student> studentsList)
        {
            var weakStudents = new List<Student>();

            foreach (var student in studentsList)
            {
                int counter = 0;

                foreach (var mark in student.Marks)
                {
                    if (mark == 2)
                    {
                        counter++;
                    }
                }

                if (counter == 2)
                {
                    weakStudents.Add(student);
                }
            }

            return weakStudents;
        }

        // Task 19
        public static void GroupedByGroupNumber(this List<Student> studentsList)
        {
            var groupedStudents = studentsList
                .GroupBy(st => st.GroupNumber);

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
        }
    }
}
