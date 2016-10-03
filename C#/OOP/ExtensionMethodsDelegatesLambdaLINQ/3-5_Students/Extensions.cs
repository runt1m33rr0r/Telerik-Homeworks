namespace _3_5_Students
{
    using System.Collections.Generic;
    using System.Linq;

    public static class Extensions
    {
        public static IEnumerable<T> SortStudentsUsingLinq<T>(
            this IEnumerable<T> students) where T : Student
        {
            var result = from student in students
                         orderby student.FirstName descending,
                         student.LastName descending
                         select student;

            return result;
        }

        public static IEnumerable<T> SortStudentsUsingLambda<T>(
            this IEnumerable<T> students) where T : Student
        {
            return students
                .OrderByDescending(x => x.FirstName)
                .ThenByDescending(x => x.LastName);
        }
    }
}
