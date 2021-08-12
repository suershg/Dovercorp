using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program15
    {
        static void add(params int[] nums)
        {
            int sum = 0;
            for(int i=0; i<nums.Length; i++)
            {
                sum = sum + nums[i];
            }
            Console.WriteLine($"{sum}");
        }
        static void Main(string[] args)
        {
            add(1, 2, 3, 4, 5);
        }
    }
}

/*
 params type:   Allow to have differnt number of arguments to a function
Can have only one params type as argument
can have another variable before to params also
*/