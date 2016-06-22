
namespace _02.IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            var test1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            foreach (var item in test1)
            {
                Console.Write(item);
                Console.Write(',');
            }
            Console.WriteLine();
            Console.WriteLine("Sum value: {0}", test1.Sum());
            Console.WriteLine("Product value: {0}", test1.Product());
            Console.WriteLine("Min value: {0}", test1.Min());
            Console.WriteLine("Max value: {0}", test1.Max());
            Console.WriteLine("Average value: {0}", test1.Average());


    }
}
}
