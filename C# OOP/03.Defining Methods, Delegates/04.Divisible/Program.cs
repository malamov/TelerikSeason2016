namespace _04.Divisible
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
   

    class Program
    {
        static void Main()
        {
            var arrOfInts = new int[] { 3, 7, 2, 3, 4, 5, 6, 7, 8, 9, 8, 5, 4, 3, 2, 21, 28, 27 };


            var divisableExtMeth = arrOfInts.Where(n => n % 3 == 0 || n % 7 == 0).ToList();

            Console.WriteLine("Numbers that are divisable by 7 and 3 (Lambda):");

            foreach (var item in divisableExtMeth)
            {
                Console.WriteLine(item + " ");
            }

            Console.WriteLine("-------------------------");
            Console.WriteLine("Numbers Divisible by 3 and 7 (LINQ) :");
            var devisibleBy7or3 =
                from number in arrOfInts
                where (number % 7 == 0 || number % 3 == 0)
                select number;

            foreach (var number in devisibleBy7or3)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine("Numbers Divisible by 3 and 7 (Conditional statement):");
            foreach (int number in arrOfInts)
            {
                if (number % 7 == 0 || number % 3 == 0)
                {
                    Console.WriteLine(number);
                }
            }

        }   
    }
}
