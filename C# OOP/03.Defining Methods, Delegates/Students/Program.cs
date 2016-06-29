namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        static void Main()
        {
            List<Student> listOfStudents = new List<Student>
            {
                 new Student("Ivan","Stefanov","14110789","024342324","helpmeplease@abv.bg",new List<int> {2,3,4,5,6,2,3},2),
                 new Student("Stoyan","Sirakov","14110689","024342324","crgcsgrscg@abv.bg",new List<int> {2,3},1),
                 new Student("Konchita","Vurst","14112289","083542324","varargrag@yahoo.bg",new List<int> {2,3,4,5,6,2,3},1),
                 new Student("Sashko","Petev","14110689","024342324","helpmeplease@abv.bg",new List<int> {2,3,4,5},2),
                 new Student("Stivan","Georgiev","14100289","052352324","helpacfemeplease@yahoo.bg",new List<int> {2,3,4,5,6,2,3},2),
                 new Student("Gergana","Petrova","14112289","024342324","helpacfemeplease@abv.bg",new List<int> {4,5},1),
                 new Student("Lubka","Lubcheva","14110689","024342324","helpmcaefeplease@yahoo.bg",new List<int> {2},2),
                 new Student("Ivana","Sivkov","14110589","062342324","acef@yahoo.bg",new List<int> {2,3,4,5,6,3},3),
                 new Student("Galena","Todorov","14112289","036542324","helpmeacfeplease@abv.bg",new List<int> {2,3,4,5,3},3),
            };
            #region Problem 9
            var group2 =                                           
                from student in listOfStudents
                orderby student.FirstName
                where (student.GroupNumber == 2)
                select student;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Students in Group 2:");
            Console.WriteLine(new string('-',40));
            Console.ForegroundColor = ConsoleColor.DarkGray;
            foreach (var stud in group2)
            {
                Console.WriteLine(stud.ToString());
            }
            #endregion

            listOfStudents.ExtractGroup2();  // Problem 10
            listOfStudents.ExtraxtByEmail(); // Problem 11
            listOfStudents.ExtractByPhone(); // Problem 12

            #region Problem 13
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Students with excelent marks:");
            Console.WriteLine(new string('-', 40));
            Console.ForegroundColor = ConsoleColor.DarkGray;
            var ExelentStudents =
                from student in listOfStudents
                where (student.Marks.Contains(6))
                select new                                                          //Problem 13
                {
                fullName = student.FirstName + " " + student.LastName,
                    marks = student.Marks
                };

            foreach (var student in ExelentStudents)
            {
                Console.WriteLine("Full name: {0}", student.fullName);
                Console.WriteLine("Marks: {0}", string.Join(", ", student.marks));
                
            }
            #endregion
            #region Problem 14
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Students with two marks only:");
            Console.WriteLine(new string('-', 40));
            Console.ForegroundColor = ConsoleColor.DarkGray;
            var studentsWithtTwoMarks =
                from student in listOfStudents
                where (student.Marks.Count == 2)
                select new                                                          //Problem 14
                {
                    fullName = student.FirstName + " " + student.LastName,
                    marks = student.Marks
                };

            foreach (var student in studentsWithtTwoMarks)
            {
                Console.WriteLine("Full name: {0}", student.fullName);
                Console.WriteLine("Marks: {0}", string.Join(", ", student.marks));

            }
            #endregion

            listOfStudents.ExtractMarksof06(); // Problem 15
            listOfStudents.GroupByGroups();    // Problem 18
        }
    }
}
