namespace _17_LongestString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LongestString
    {
        private static void Main()
        {
            List<string> stringsList = new List<string>() { "e", "dwedw", "dwedwdewd", "dwedwddwded", "dwdwdwedwdeddewedewded" };

            var longestString = stringsList
                .First(str => str.Length == stringsList.Max(st => st.Length));

            Console.WriteLine(longestString);
        }
    }
}
