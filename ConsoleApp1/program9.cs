using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    enum gender
    {
        male, female, other
    }
    class program9
    {
        static void Main(string[] args)
        {
            gender a1 = gender.male;
            gender a2 = gender.female;
            if(a1 == gender.female)
            {
                Console.WriteLine("you are not allowed after 6");
            }
            else
            {
                Console.WriteLine("you are not allowed after 8");
            }
        }
    }
}
