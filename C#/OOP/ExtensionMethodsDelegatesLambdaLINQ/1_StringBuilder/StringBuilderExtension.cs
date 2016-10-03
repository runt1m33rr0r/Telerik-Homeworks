namespace _1_StringBuilder
{
    using System;
    using System.Text;

    public static class StringBuilderExtension
    {
        public static StringBuilder Substring(this StringBuilder strBuild, int startIndex, int length)
        {
            string subStr = strBuild.ToString().Substring(startIndex, length);

            return new StringBuilder(subStr);
        }

        private static void Main()
        {
            StringBuilder test = new StringBuilder("testing our extension method");

            Console.WriteLine(test.Substring(0, 7));
        }
    }
}
