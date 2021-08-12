using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter pmr");
            int pmr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter lmr");
            int lmr = Convert.ToInt32(Console.ReadLine());

            int bu = pmr - lmr;
            double ur;
            if (bu < 150)
                ur = 1.75;
            else if (bu < 375) ur = 3.25;
            else if (bu < 500) ur = 5;
            else ur = 6.5;

            double amount = bu * ur;
            Console.WriteLine($" amount is : {amount}");
        }
    }
}
