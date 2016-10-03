using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

static class ReplaceTags
{
    private static void Main()
    {
        string input = Console.ReadLine();
        string[] arrInput = Regex.Split(input, "(<a href=\")");
        StringBuilder result = new StringBuilder();

        if (arrInput[0] != "<a href=\"")
        {
            result.Append(arrInput[0]);
        }

        for (int i = 0; i < arrInput.Length - 1; i++)
        {
            if (arrInput[i] == "<a href=\"")
            {
                string nextSentance = arrInput[i + 1];

                // capture site name
                List<char> siteName = new List<char>();

                for (int j = 0; j < nextSentance.Length; j++)
                {
                    if (nextSentance[j] == '"')
                    {
                        break;
                    }
                    else
                    {
                        siteName.Add(nextSentance[j]);
                    }
                }

                //capture site text
                List<char> siteText = new List<char>();

                for (int j = siteName.Count + 2; j < nextSentance.Length; j++)
                {
                    if (nextSentance[j] == '<')
                    {
                        break;
                    }
                    else
                    {
                        siteText.Add(nextSentance[j]);
                    }
                }

                result.Append(string.Format("[{0}]({1})", new string(siteText.ToArray()), new string(siteName.ToArray())));
                int startCut = siteName.Count + siteText.Count + 6;
                result.Append(nextSentance.Substring(startCut, nextSentance.Length - startCut));
            }
        }

        Console.WriteLine(result.ToString());
    }
}