using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IEnumerableExtensions
{
    public static class Extensions
    {
        public static T Sum<T>(this IEnumerable<T> collection) where T : struct
        {
            T result = (dynamic)0;

            foreach (T item in collection)
            {
                result += (dynamic)item;
            }

            return result;
        }

        public static T Product<T>(this IEnumerable<T> collection) where T : struct
        {
            T result = (dynamic)1;

            foreach (T item in collection)
            {
                result *= (dynamic)item;
            }

            return result;
        }

        public static T Max<T>(this IEnumerable<T> collection) where T : struct
        {
            T max = (dynamic)int.MinValue;

            foreach (T item in collection)
            {
                if ((dynamic)item > (dynamic)max)
                {
                    max = item;
                }
            }

            return max;
        }

        public static T Min<T>(this IEnumerable<T> collection) where T : struct
        {
            T min = (dynamic)int.MaxValue;

            foreach (T item in collection)
            {
                if ((dynamic)item < (dynamic)min)
                {
                    min = item;
                }
            }

            return min;
        }

        public static double Average<T>(this IEnumerable<T> collection) where T : struct
        {
            return (dynamic)collection.Sum() / collection.Count();
        }

       
    }
}
