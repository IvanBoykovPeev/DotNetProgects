using System;

namespace _07.ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 0; row <= n; row++)
            {
                for (int cow = 0; cow < n - row; cow++)
                {
                    Console.Write(" ");
                }
                
                for (int i = 0; i < row; i++)
                {
                    Console.Write("*");
                }

                Console.Write(" | ");

                for (int i = 0; i < row; i++)
                {
                    Console.Write("*");
                }
                for (int cow = 0; cow < n - row + 1; cow++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
