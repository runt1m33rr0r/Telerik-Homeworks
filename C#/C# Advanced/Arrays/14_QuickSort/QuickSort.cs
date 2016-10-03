using System;
using System.Collections.Generic;

class QuickSort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var numbers = new List<int>();

        for (int i = 0; i < n; i++)
        {
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        var result = sort(numbers);

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }

    static List<int> sort(List<int> array)
    {
        var less = new List<int>();
        var equal = new List<int>();
        var greater = new List<int>();

        if (array.Count > 1)
        {
            int pivot = array[0];

            foreach (var item in array)
            {
                if (item < pivot)
                {
                    less.Add(item);
                }
                if (item == pivot)
                {
                    equal.Add(item);
                }
                if (item > pivot)
                {
                    greater.Add(item);
                }
            }

            var all = new List<int>();
            all.AddRange(sort(less));
            all.AddRange(equal);
            all.AddRange(sort(greater));

            return all;
        }
        else
        {
            return array;
        }
    }
}

