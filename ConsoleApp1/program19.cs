using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program19
    {
        static void Main(string[] args)
        {
            /* int ?a = null;

             try
             {
                 //this block contains statements which may provide exception
                 a = Convert.ToInt32(Console.ReadLine());
             }
             catch(FormatException ex)
             {
                 // this block used to handle exception
                 Console.WriteLine("input not valid"+ex.Message);
                 a = 0;
             }
             catch(Exception ex)
             {
                 //
                 Console.WriteLine(ex.Message);
             }
             finally
             {
                 //this block process statements even the error raises or not
                 Console.WriteLine($" squre of {a} is {a * a}");
             }

             Console.WriteLine("Hello World");
             Console.WriteLine("Hello India");*/


            /*int ?a = null, b, c;
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("hello try");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Invalid inpout"+ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("divide by zero" + ex.Message);
                c = a / 2;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
            */



            /*int[] nums = new int[5] { 1, 2, 3, 4, 5 };

            try
            {
                Console.WriteLine(nums[5]);
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error : "+ ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            */


            /* try
             {
                 int[] nums = new int[5];
                 Console.WriteLine("Enter no's ");
                 for (int i = 0; i < 6; i++)
                     nums[i] = int.Parse(Console.ReadLine());

                 for (int i = 0; i < nums.Length; i++)
                     Console.Write(nums[i]+"  ");
             }
             catch(IndexOutOfRangeException ex)
             {
                 Console.WriteLine("Error: " + ex.Message);
             }
             catch(Exception ex)
             {
                 Console.WriteLine("Error : " + ex.Message);
             }
            */

            string[] names = { "hello", "world", "raj", "one" };
            foreach(String name in names)
            {
                Console.WriteLine(name);
            }

            int[] nums = new int[] { 1, 2, 3, 4, 5, 6 };
            foreach(int num in  nums)
            {
                Console.WriteLine(num);
            }
        }
    }
}
