using System;

class MergeSort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        sort(numbers);

        Console.WriteLine(string.Join(Environment.NewLine, numbers));
    }

    public static void sort<T>(T[] a)
    where T : IComparable<T>
    {
        sort(a, 0, a.Length);
    }

    public static void sort<T>(T[] a, int low, int high)
        where T : IComparable<T>
    {
        int N = high - low;
        if (N <= 1)
            return;

        int mid = low + N / 2;

        sort(a, low, mid);
        sort(a, mid, high);

        T[] aux = new T[N];
        int i = low, j = mid;
        for (int k = 0; k < N; k++)
        {
            if (i == mid) aux[k] = a[j++];
            else if (j == high) aux[k] = a[i++];
            else if (a[j].CompareTo(a[i]) < 0) aux[k] = a[j++];
            else aux[k] = a[i++];
        }

        for (int k = 0; k < N; k++)
        {
            a[low + k] = aux[k];
        }
    }
}

