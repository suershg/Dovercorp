using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class program6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No");
            int d = Convert.ToInt32(Console.ReadLine());
            switch(d)
            {
                case 1:
                    Console.WriteLine("North");
                    break;
                case 2:
                    Console.WriteLine("South");
                    break;
                case 3:
                    Console.WriteLine("East");
                    break;
                case 4:
                    Console.WriteLine("West");
                    break;
                default:
                    Console.WriteLine(" Invalid choice .....");
                    break;
            }
        }   
    }
}
