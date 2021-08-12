using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program17
    {
        static int Factorial(int a)
        {
            int ans = 1;
            for(int i=2; i<=a; i++)
            {
                ans = ans * i;
            }
            return ans;
        }
        static int Reverse(int a)
        {
            int ans = 0;
            int num;
            while (a != 0)
            {
                num = a % 10;
                ans = ans * 10 + num;
                a = a / 10;
            }
            return ans;
        }
        static int Smallest(int a, int b)
        {
            return a > b ? b : a;
        }
        static int Biggest(int a, int b)
        {
            return a > b ? a : b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(6));
            Console.WriteLine(Reverse(456));
            Console.WriteLine(Smallest(10, 32));
            Console.WriteLine(Biggest(33, 43));
        }
    }
}
