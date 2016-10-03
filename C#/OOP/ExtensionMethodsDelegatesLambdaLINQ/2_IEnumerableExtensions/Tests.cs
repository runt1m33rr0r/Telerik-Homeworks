namespace _2_IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;

    public static class Tests
    { 
        private static void Main()
        {
            var someCollection = new List<int>() { 4, -6, 5, 10, 35 };

            Console.WriteLine("product: {0}", someCollection.Product());
            Console.WriteLine("sum: {0}", someCollection.Sum());
            Console.WriteLine("avarage: {0}", someCollection.Avarage());
            Console.WriteLine("max element: {0}", someCollection.Max());
            Console.WriteLine("min element: {0}", someCollection.Min());

            var someArray = new float[] { 1.3f, 4.36f, -1.78f, 8.3f, 4.9f };

            Console.WriteLine();

            Console.WriteLine("product: {0}", someArray.Product());
            Console.WriteLine("sum: {0}", someArray.Sum());
            Console.WriteLine("avarage: {0}", someArray.Avarage());
            Console.WriteLine("max element: {0}", someArray.Max());
            Console.WriteLine("min element: {0}", someArray.Min());
        }
    }
}
