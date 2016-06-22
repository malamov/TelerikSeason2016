namespace StrBuilderExtensions
{
    using System;
    using System.Text;

    class Program
    {
        static void Main()
        {
            var sb = new StringBuilder();
            sb.Append("This is some random text");
            Console.WriteLine(sb.Substring(5, 15));
            Console.ReadLine();

        }
    }
}
