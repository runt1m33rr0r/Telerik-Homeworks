namespace GenericClass
{
    using System;

    public class Test
    {
        public static void Main()
        {
            GenericList<int> firstList = new GenericList<int>(16);
            Console.WriteLine(firstList);

            firstList.Add(31);
            Console.WriteLine(firstList);

            firstList.AddAtPosition(52,0);
            Console.WriteLine(firstList);

            int findThis = 31;
            int firstOccur = firstList.Find(findThis);
            Console.WriteLine("Element {0} is with {1} index",findThis, firstOccur);

            firstList.RemoveAt(1);
            Console.WriteLine(firstList);

            firstList.Clear();
            Console.WriteLine(firstList);

            GenericList<int> secondList = new GenericList<int>(16);

            for (int i = 0; i < 2; i++)
            {
                secondList.Add(0);
                secondList.Add(10);
                secondList.Add(15);
                secondList.Add(5);
                secondList.Add(3);
                secondList.Add(-1);
                secondList.Add(100);
            }
            
            

            Console.WriteLine(secondList);

            Console.WriteLine("Min is {0}", secondList.Min());
            Console.WriteLine("Max is {0}", secondList.Max());

        }
    }
}
