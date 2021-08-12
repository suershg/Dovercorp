using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Line");
            char ch = Convert.ToChar(Console.ReadLine());

            /* Console.WriteLine($"given char is {ch}");
             Console.WriteLine($"next chat {ch + 1}  and {(char)(ch + 1)}");
             Console.WriteLine($"next chat {ch - 1}  and {(char)(ch - 1)}");
            */

            if (ch >= 65 && ch <= 90)
                Console.WriteLine($"{ch} is a capital letter");
            else if (ch >= 97 && ch <= 122)
                Console.WriteLine($"{ch} is small letter");
            else if (ch >= 48 && ch <= 57)
                Console.WriteLine($"{ch} is number");
            else
                Console.WriteLine($"{ch} is a special letter");
        }
    }
}
