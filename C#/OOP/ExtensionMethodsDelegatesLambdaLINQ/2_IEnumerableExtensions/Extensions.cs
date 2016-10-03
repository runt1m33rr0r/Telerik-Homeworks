namespace _2_IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Extensions
    {
        public static T Sum<T>(this IEnumerable<T> someCollection) where T : IConvertible
        {
            T sum = (dynamic)0;

            foreach (var item in someCollection)
            {
                sum += (dynamic)item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> someCollection) where T : IConvertible
        {
            T product = (dynamic)1;

            foreach (var item in someCollection)
            {
                product *= (dynamic)item;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> someCollection) where T : IComparable
        {
            T smallestItem = default(T);

            foreach (var item in someCollection)
            {
                if (item.CompareTo(smallestItem) == -1)
                {
                    smallestItem = item;
                }
            }

            return smallestItem;
        }

        public static T Max<T>(this IEnumerable<T> someCollection) where T : IComparable
        {
            T biggestItem = default(T);

            foreach (var item in someCollection)
            {
                if (item.CompareTo(biggestItem) == 1)
                {
                    biggestItem = item;
                }
            }

            return biggestItem;
        }

        public static double Avarage<T>(this IEnumerable<T> collection) where T : IConvertible
        {
            var sum = collection.Sum();
            var count = collection.Count();
            double avarage = (dynamic)sum / (double)count;

            return avarage;
        }
    }
}
