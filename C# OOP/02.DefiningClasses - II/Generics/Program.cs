using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new GenericList<int>(10);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
       
            list.Insert(3, 777777);
            list.Remove(4);
            list.Add(99999);
            Console.WriteLine("Minimal value: {0}",list.Min());
            Console.WriteLine("Maximal value: {0}",list.Max());
            Console.WriteLine(list);
    


        }
    }
}
