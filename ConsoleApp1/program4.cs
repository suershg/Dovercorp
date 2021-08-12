using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a maths Marks ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter a physics Marks ");
            int p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter a Chemistry Marks ");
            int c = Convert.ToInt32(Console.ReadLine());

            int total = m + p + c;
            double avg = (double)total / 3;

            Console.WriteLine($"total : {total}");
            Console.WriteLine($"Average : {avg}");

            string result = string.Empty;
            string grade;
            if(m>=35 && p>=35 && c>=35)
            {
                result = "PASS";
                if (avg >= 75) grade = "A1";
                else if (avg >= 60) grade = "A";
                else grade = "B";
            }
            else
            {
                result = "FAIL";
                grade = "NA";
            }

            Console.WriteLine($"result = {result}");
            Console.WriteLine($"grade = {grade}");

        }
    }
}

/* if 
 * case  : used for constant expression in the condition
 * loop : to iterate statements
 * 
 * 
 */