namespace VersionAttribute
{
    using System;

    [Version("1.00")]
    public class Test
    {
        public static void Main()
        {
            Type type = typeof(Test);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute attr in allAttributes)
            {
                Console.WriteLine("Test is version: " + attr.Version);
            }
        }
    }
}
