using System;
using System.Globalization;

class Age
{
    static void Main()
    {
        DateTime inputDate = DateTime.ParseExact(Console.ReadLine(), "MM.dd.yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine(new DateTime().Add(DateTime.Now.Subtract(inputDate)).Year - 1);

        Console.WriteLine(new DateTime().Add(DateTime.Now.Subtract(inputDate)).Year + 9);
    }
}