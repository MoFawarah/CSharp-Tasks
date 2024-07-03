using System;
using System.Collections.Generic;
namespace ConsoleApp7
{
    internal class Program
    {

        class Things
        {
           public static void PrintHello()
            {
                Console.WriteLine("Hello");
            }


            public void PrintBye()
            {
                Console.WriteLine("Bye");
            }
        }




        //Regular Method (standalone)

        static void Print()
        {
            Console.WriteLine("Sara is a clever girl");
        }

        static void Main(string[] args)
        {
            Print(); //can be called directly
            Things.PrintHello(); // when inside a class, it can be accessed without needing an object

            Things thing = new Things();
            thing.PrintBye(); // this function is not static, so it needs an object to be accessed.
        }
    }
}
