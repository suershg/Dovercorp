using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class program8
    {
        static void Main(string[] args)
        {
            Object o1 = "kiran";//boxing
            Console.WriteLine(o1 +  " " + o1.GetType());

            string name = o1.ToString(); //unboxing
            Console.WriteLine(name + " " + name.GetType());

            o1 = 1000; //boxing
            Console.WriteLine(o1 + " " + o1.GetType());

            int n = (int)o1; //unboxing
            Console.WriteLine(n+" "+n.GetType());
        }
    }
}
/* datatypes used in .NET are available in a hierarchy called CTC(Commom )
 * 
 * 
 * 
 * 
 * 
 */