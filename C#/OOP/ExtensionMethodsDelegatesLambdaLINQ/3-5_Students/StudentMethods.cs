namespace _3_5_Students
{
    using System.Linq;

    public class StudentMethods
    {
        public static Student[] GetFirstBeforeLastNames(Student[] students)
        {
            return students
                .Where(st => string.Compare(st.FirstName, st.LastName) < 0)
                .ToArray();
        }

        public static Student[] AgeRange(Student[] students)
        {
            return students
                .Where(st => st.Age >= 18 && st.Age <= 24)
                .ToArray();
        }
    }
}
