using System;
using System.Text.RegularExpressions;

class SubstringInText
{
    static void Main()
    {
        string needle = Console.ReadLine();
        string haystack = Console.ReadLine();

        int count = new Regex(Regex.Escape(needle), RegexOptions.IgnoreCase).Matches(haystack).Count;

        Console.WriteLine(count);
    }
}