using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program16
    {
        static void display()
        {
            Console.WriteLine("\n Hello World");
        }
        static void display(String name)
        {
            Console.WriteLine($"\n{name}");
        }
        static void Main(string[] args)
        {
            display();
            display("suresh");
        }
        
    }
}
