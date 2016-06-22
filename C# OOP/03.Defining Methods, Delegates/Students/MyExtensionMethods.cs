namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   public static class MyExtensionMethods
    {
        public static void ExtractGroup2(this List<Student> list)
        {
            var group2 =
                from student in list
                orderby student.FirstName
                where (student.GroupNumber == 2)
                select student;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Students in Group 2 (By an extension method):");
            Console.WriteLine(new string('-', 40));
            Console.ForegroundColor = ConsoleColor.DarkGray;
            foreach (var stud in group2)
            {
                Console.WriteLine(stud.ToString());
            }
        }

        public static void ExtraxtByEmail(this List<Student> list)
        {
            var abvAccounts =
                from student in list
                where (student.Email.Substring(student.Email.Length - 6, 3) == "abv")
                select student;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Students with accounts in abv.bg:");
            Console.WriteLine(new string('-', 40));
            Console.ForegroundColor = ConsoleColor.DarkGray;
            foreach (var stud in abvAccounts)
            {
                Console.WriteLine(stud.ToString());
            }
        }

        public static void ExtractByPhone(this List<Student> list)
        {
            var fromSofia =
                 from student in list
                 where (student.Tel.Substring(0,2) == "02")
                 select student;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Students with Telephones in Sofia:");
            Console.WriteLine(new string('-', 40));
            Console.ForegroundColor = ConsoleColor.DarkGray;
            foreach (var stud in fromSofia)
            {
                Console.WriteLine(stud.ToString());
            }

        }

        public static void ExtractMarksof06(this List<Student> list)
        {
            var listOf06 =
                from stud in list
                where (stud.FN.Substring(4, 2) == "06")
                select stud;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Students with enrolled in 06:");
            Console.WriteLine(new string('-', 40));
            Console.ForegroundColor = ConsoleColor.DarkGray;
            foreach (var stud in listOf06)
            {
                Console.WriteLine("Last name: {0}", stud.LastName);
                Console.WriteLine("Marks: {0}", string.Join(", ", stud.Marks));
            }

        }

        public static void GroupByGroups(this List<Student> list)
        {
            var groupedList =
                from stud in list
                orderby stud.GroupNumber ascending
                select stud;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Students by Groups");
            Console.WriteLine(new string('-', 40));
            Console.ForegroundColor = ConsoleColor.DarkGray;
            foreach (var stud in groupedList)
            {
                Console.WriteLine(stud);
            }
        }
    }
}
