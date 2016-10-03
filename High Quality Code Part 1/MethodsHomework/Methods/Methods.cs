namespace Methods
{
    using System;
    using Geometry;
    using GlobalConstants;
    using Numbers;
    using Printing;

    internal class Methods
    {
        private static void Main()
        {
            Console.WriteLine(GeometryOperations.CalculateTriangleArea(3, 4, 5));
            Console.WriteLine(NumberOperations.NumberToDigit(5));
            Console.WriteLine(NumberOperations.FindMax(5, -1, 3, 2, 14, 2, 3));

            Printer.PrintAsNumber(1.3, "f");
            Printer.PrintAsNumber(0.75, "%");
            Printer.PrintAsNumber(2.30, "r");

            bool horizontal, vertical;

            Console.WriteLine(GeometryOperations.CalculateDistance(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student()
            {
                FirstName = "Peter",
                LastName = "Ivanov",
                OtherInfo = "From Sofia, born at 17.03.1992"
            };

            Student stella = new Student()
            {
                FirstName = "Stella",
                LastName = "Markova",
                OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993"
            };

            Console.WriteLine(FormatStrings.StudentInfo, peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
