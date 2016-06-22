using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SortStudents
{
  public static class Methods
    {
        public static void CheckNames(this Student[] arr)
        {
            //LINQ operator
            var FirstNameBeforeLast =
                from student in arr
                where (student.FirstName.CompareTo(student.LastName) < 0)
                select student;
            //LINQ operator
            var sb = new StringBuilder();
            sb.AppendLine("Students who have their first name alphabetically smaller than their last name:");
            foreach (var stud in FirstNameBeforeLast)
            {
                sb.Append($"{stud.FirstName} {stud.LastName}, ");
            }
            int lastIndex = sb.Length;
            sb.Remove(lastIndex - 2, 1);
            sb.Append(".");
            Console.WriteLine(sb.ToString());
            Console.WriteLine();

        }

        public static void CheckAge(this Student[] arr)
        {

            //LINQ operator
            var between18and24 =
                from student in arr
                where (student.Age > 18 && student.Age < 24)
                select student;
            //LINQ operator
            var sb = new StringBuilder();
            sb.AppendLine("Students aged between 18 and 24:");
            foreach (var stud in between18and24)
            {
                sb.Append($"{stud.FirstName} {stud.LastName}, ");
            }
            int lastIndex = sb.Length;
            sb.Remove(lastIndex - 2, 1);
            sb.Append(".");
            Console.WriteLine(sb.ToString());
            Console.WriteLine();

        }

        public static void SortByLinq(this Student[] arr)
        {
            var sortedArr =
                from student in arr
                orderby student.FirstName
                select student;

            var sb = new StringBuilder();
            sb.AppendLine("Students ordered by their first name (LINQ):");
            int position = 1;
            foreach (var student in sortedArr)
            {
                sb.AppendLine($"{position}. {student.FirstName} {student.LastName}");
                position++;
            }
            Console.WriteLine(sb.ToString());
        }

        public static void SortByLambda(this Student[] arr)       
        {
            var sortedList = arr.OrderBy(st => st.FirstName);
            Console.WriteLine("Sorted with Lambda operator:");
            int i = 1;
            foreach (var st in sortedList)
            {
                Console.WriteLine($"{i}. {st.FirstName} {st.LastName}");
                i++;
            }
        }
    }
}
