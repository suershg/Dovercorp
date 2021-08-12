using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program18
    {
        static void Main(string[] args)
        {
            int ?a = null;
            if (a == null)
                Console.WriteLine($"a is null {a}");
            else
                Console.WriteLine(a);

            string name = string.Empty;
            if (string.IsNullOrEmpty(name))
                Console.WriteLine("is null");
            else
                Console.WriteLine($"{name} is the value");
        }
    }
}

/*
 * nullbale types: used to have empty value into a variable
 * by prefix ? to the variable
 * int ?n=null;
 * 
 * To compare
 * if( n is null)
 *  statement
 */