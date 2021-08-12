using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class program12
    {
        static void Main(string[] args)
        {
            /*int[] items = new int[5];

            for (int i = 0; i < items.Length; i++)
                Console.Write($"{i} :  ");

            for (int i = 0; i < items.Length; i++) 
                items[i] = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < items.Length; i++)
                Console.Write($"\n {i} : {items[i]} ");
            */
            /*string[] names = new string[5];

            for (int i = 0; i < names.Length; i++)
                Console.Write($"\n  {i} : {names[i]} ");

            for (int i=0; i<names.Length; i++)
            {
                Console.Write($"\n Enter {i} name :");
                names[i] = Console.ReadLine();
            }
            for (int i = 0; i < names.Length; i++)
                Console.Write($"\n  {i} : {names[i]} ");*/

            int[] marks = new int[5];
            int sum = 0, count = marks.Length, avg, min=0, max=0;
            for (int i=0; i < marks.Length; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
                sum += marks[i];
                if(i==0)
                {
                    min = marks[0];
                    max = marks[0];
                }
                else if (min > marks[i])
                {
                     min = marks[i];
                }
                else if(max < marks[i])
                    max = marks[i];
            }
            avg = sum / count;
            Console.WriteLine($"count = {count}, avg = {avg}, sum = {sum}, max = {max}, min = {min}");
        }
    }
}
