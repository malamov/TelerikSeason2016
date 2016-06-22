namespace Timer
{
    using System;

    class Program
    {
        static void Main()
        {
            Timer timer = new Timer(1);

            timer.SomeMethods += FirstTestMethod;
            timer.SomeMethods += SecondTestMethod;
            timer.ExecuteMethods();
        }

        public static void FirstTestMethod()
        {
            Console.Write("Tick-");
        }

        public static void SecondTestMethod()
        {
            Console.WriteLine("Tock");
        }
    }
}