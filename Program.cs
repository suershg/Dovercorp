using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* String name;
             name = "suresh moses gadde";
             Console.WriteLine(name);
             Console.WriteLine($"hello {name}");
             Console.WriteLine($"length is {name.Length}");
             Console.WriteLine($"Upper case {name.ToUpper()}");
             Console.WriteLine($"Lower case {name.ToLower()}");
             Console.WriteLine($"IndexOf s {name.IndexOf('s')}" );
             Console.WriteLine($"last Index of {name.LastIndexOf('s')}");
             Console.WriteLine($"substring 0, 3 {name.Substring(0, 3)}");
             Console.WriteLine($" substring 4, 5 {name.Substring(4, 1)}");


             Console.WriteLine(name.Substring(1));
             Console.WriteLine(name.Substring(0, name.Length-1));
             Console.WriteLine(name.Substring(0, name.IndexOf(" ")));
             Console.WriteLine(name.Substring(name.LastIndexOf(" ") + 1));

             int x = 2;
             Console.WriteLine($" x = {x}, type = {x.GetType()}");
             char y = 'r';
             Console.WriteLine($" y = {y} type = {y.GetType()}");
             var z = "suresh";
             Console.WriteLine($"z = {z} type = {z.GetType()}");
             double d = 3.4456;
             Console.WriteLine($"d ={d},  type = {d.GetType()}");
             bool b = true;
             Console.WriteLine($" b = {b},  type = {b.GetType()}");

             Console.WriteLine("what is your name");
             name = Console.ReadLine();
             Console.WriteLine($"hello {name},  How are you");

             Console.WriteLine("write a number");
             int n = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine($"n = {n}, n+1 = {n+1}");
             Console.WriteLine($"n*n = {n * n}");*/

            Console.WriteLine("Enter no1 : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter no2 : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"additon of {a} and {b} is {a + b}");
            Console.WriteLine($"sub of {a} and {b} is {a - b}");
            Console.WriteLine($"multiplication of {a} and {b} is {a * b}");
            Console.WriteLine($"division of {a} and {b} is {a / b}");
        }
    }
}
