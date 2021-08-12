using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class program11
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("============================while loop =========================");

            i = 1;
            while (i <= 10)
            {
                Console.Write($"{i} ");
                i++;
            }
            //Console.WriteLine();
            Console.WriteLine("\n============================for loop =========================");
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{j} ");
            }
            //Console.WriteLine();
            Console.WriteLine("\n============================ do while loop =========================");

            i = 1;
            do
            {
                Console.Write($"{i} ");
                i++;
            } while (i <= 10);


            Console.WriteLine("\n sleep method");
            i = 1;
            while (i <= 10)
            {
                Console.WriteLine($" {i}  {11 - 1}");
                Thread.Sleep(1000);
                i++;
            }

            int a = 0, b = 1, c;
            Console.Write($"\n {a} {b} ");

            i = 2;
            while(i < 10)
            {
                c = a + b;
                Console.Write($"{c} ");
                a = b;
                b = c;
            }



        }
    }
}
