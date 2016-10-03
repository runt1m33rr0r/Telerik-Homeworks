using System;

class IndexOfLetters
{
    static void Main()
    {
        string input = Console.ReadLine();

        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        foreach (var letter in input)
        {
            foreach (var alphabetLetter in alphabet)
            {
                if (letter == alphabetLetter)
                {
                    Console.WriteLine(Array.IndexOf(alphabet, alphabetLetter));
                }
            }
        }
    }
}

