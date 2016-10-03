using System;
using System.Text;

class ParseTags
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] arrInput = input.Split(new string[] { "</upcase>" }, StringSplitOptions.RemoveEmptyEntries);
        StringBuilder finalText = new StringBuilder();

        for (int i = 0; i < arrInput.Length; i++)
        {
            if (arrInput[i].Contains("<upcase>"))
            {
                int startIndex = arrInput[i].IndexOf("<upcase>") + "<upcase>".Length;

                if (startIndex != 0)
                {
                    finalText.Append(arrInput[i].Substring(0, startIndex - "<upcase>".Length));
                }

                finalText.Append(arrInput[i].Substring(startIndex, arrInput[i].Length - startIndex).ToUpper());
            }
            else
            {
                finalText.Append(arrInput[i]);
            }
        }

        Console.WriteLine(finalText.ToString());
    }
}