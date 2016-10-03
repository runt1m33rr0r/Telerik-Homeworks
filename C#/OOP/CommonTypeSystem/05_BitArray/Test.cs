namespace _05_BitArray
{
    using System;

    public class Test
    {
        public static void Main()
        {
            BitArray firstArray = new BitArray(4949448445);
            BitArray secondArray = new BitArray(8484846684);
            BitArray thirdArray = new BitArray(544623);

            Console.WriteLine("Hash code: {0}", firstArray.GetHashCode());

            Console.WriteLine("The first array equal to the second: {0}", firstArray.Equals(secondArray));

            Console.WriteLine("Third index of array: {0}", firstArray[3]);

            Console.WriteLine("FirstArray is different from secondArray: {0}", firstArray != secondArray);

            Console.WriteLine("FirstArray is equal to thrirdArray: {0}", firstArray == thirdArray);
        }
    }
}
