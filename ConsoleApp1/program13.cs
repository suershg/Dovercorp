using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class program13
    {
        static void Main(string[] args)
        {
            /*int[,] items = new int[2, 2];

            items[0, 0] = 100;
            items[0, 1] = 101;

            items[1, 0] = 102;
            items[1, 1] = 103;

            Console.Write($"items[0,0] = {items[0, 0]}");
            Console.Write($"items[0,0] = {items[0, 1]}");

            Console.Write($"items[0,0] = {items[1, 0]}");
            Console.Write($"items[0,0] = {items[1, 1]}");*/

            int[][] jagged = new int[4][];

            jagged[0] = new int[] { 1, 2, 3 };
            jagged[1] = new int[] { 23, 45, 6, 7, 8, 9, 0 };
            jagged[2] = new int[] { 0 };
            jagged[3] = new int[] { 3, 4 };

            for(int i=0; i<4; i++)
            {
                for(int j=0; j < jagged[i].Length; j++)
                {
                    Console.Write($"{jagged[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
