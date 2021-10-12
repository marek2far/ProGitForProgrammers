using System;
using System.Collections.Generic;

namespace ProGItForProgrammers
{
    public class Book
    {
        public string Title { get; set; }
        public List<string> Authors { get; set; }
        public DateTime PublicationDate { get; set; }
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
