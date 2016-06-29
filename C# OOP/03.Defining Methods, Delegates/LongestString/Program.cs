using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArr = new string[]
            {
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
                 "Morbi in scelerisque nulla, a ultrices turpis. Nunc egestas purus erat, non iaculis sem tincidunt et. ",
                  "auctor nibh bibendum enim",
                   "Aliquam interdum ex et viverra euismod. ",
                    "Maecenas vel mattis dui. Nam vel est neque.",
                   "sodales"
            };

            var longest =
                from sentence in strArr
                orderby sentence.Length descending
                select sentence;

            Console.WriteLine(longest.First().Length + " chars");



        }
    }
}
