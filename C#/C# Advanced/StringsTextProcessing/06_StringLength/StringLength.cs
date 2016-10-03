using System;
using System.Text;

class StringLength
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder finalText = new StringBuilder();

        input = input.Replace(@"\", string.Empty);

        finalText.Append(input);

        if (input.Length < 20)
        {
            finalText.Append(new string('*', 20 - input.Length));
        }
        Console.WriteLine(finalText.ToString());
    }
}