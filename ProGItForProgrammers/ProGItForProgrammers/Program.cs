using System;

namespace ProGItForProgrammers
{
    public class Calculator
    {
        public int Add (int left, int right)
        {
            return left + right;
        }

        public int Subtract (int left, int right)
        {
            return left - right;
        }

        public int Multiply(int left, int right)
        {
            return left * right;
        }
}

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("I just added this in Visual Studio");
            Console.WriteLine("I just added this in the command line repo");
            Console.WriteLine("This line added to show the staging area");
        }
    }
}
