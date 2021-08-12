using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class program14
    {
        /*static void DrawLine()
        {
            for (int i = 0; i <= 100; i++)
                Console.Write("**");
            Console.WriteLine();
        }*/
        /*static void display()
        {
            Console.WriteLine("Hello Wprld");
        }
        static void wishes(string name)
        {
            if (DateTime.Now.Hour < 12)
                Console.WriteLine($" Good Morning {name}");
            else if (DateTime.Now.Hour < 16)
                Console.WriteLine($" Good Afternoon {name}");
            else
                Console.WriteLine($"Good evening {name}");
        }*/
      /*  static void Displayvar(int a, int b)
        {
            Console.WriteLine($" a= {a}, b = {b}");
        }
        static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }*/
        static void Outex(out int c)
        {
            c = 100;
        }
        static void Main(string[] args)
        {
            //int a = 10, b = 11;
            int c;
            /*displayvar(a, b);
            swap(ref a, ref b);
            displayvar(a, b);*/

            Outex(out c);
            Console.WriteLine(c);

        }
    }
}
