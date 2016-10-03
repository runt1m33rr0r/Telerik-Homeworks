using System;
using System.Text;
using System.Linq;

class ExtractSentences
{
    static void Main()
    {
        string inputWord = Console.ReadLine().Trim();
        string text = Console.ReadLine();
        StringBuilder result = new StringBuilder();

        string[] sentences = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
        char[] separators = text.Where(ch => char.IsLetter(ch) == false).Distinct().ToArray();

        foreach (string sentence in sentences)
        {
            string[] words = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                if (word.Trim() == inputWord)
                {
                    result.Append(string.Format("{0}. ", sentence.Trim()));
                    break;
                }
            }
        }

        Console.WriteLine(result);
    }
}