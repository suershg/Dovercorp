using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the name");
            String name = Console.ReadLine();

            string firstName = name.Substring(0, name.IndexOf(" "));
            string lastName = name.Substring(name.LastIndexOf(" ") + 1);

            Console.WriteLine($" firstName = {firstName}");
            Console.WriteLine($" lastName = {lastName}");
        }
    }
}

// chRACTER REFERS TO ANY LETTER INCLUDING ALPHABETS, DIGIT, SPECIAL letters 
/*  A - Z  are 65 to 90
 * a - z   are 97 to 122
 * 0 - 9   are 48 to 57
 */