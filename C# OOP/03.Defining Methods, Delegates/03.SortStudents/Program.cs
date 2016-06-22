using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SortStudents
{
   public class Program
    {
        static void Main()
        {
            var studentsArr = new Student[]
            {
                new Student("Mihail","Malamov",21),
                new Student("Asen","Zaimov",33),
                new Student("Boayan","Popov",20),
                new Student("Zlatimir","Boyadziev",19),
                new Student("Dimiter","Stoimenov",22),
                new Student("Jeff","Ivanov",18),
                new Student("Stefan","Terziev",16),
                new Student("Jivko","Sirakov",26)
            };

            studentsArr.CheckNames();
            studentsArr.CheckAge();
            studentsArr.SortByLinq();
            studentsArr.SortByLambda();

        }
    }
}
