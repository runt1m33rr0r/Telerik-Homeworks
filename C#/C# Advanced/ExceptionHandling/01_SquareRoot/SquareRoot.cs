using System;

class SquareRoot
{
    static void Main()
    {
        try
        {
            double inputNumber = double.Parse(Console.ReadLine());

            if (inputNumber < 0)
            {
                throw new FormatException();
            }

            Console.WriteLine("{0:F3}", Math.Sqrt(inputNumber));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}