using System;

namespace _06.RhombusОfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int cow = 1; cow <= n - row; cow++)
                {
                Console.Write(" ");
                }
                Console.Write('*');
                for (int cow = 1; cow < row; cow++)
                {
                    Console.Write(" *");
                }
            Console.WriteLine();
            }

            for (int row = 1; row <= n - 1; row++)
            {
                for (int cow = 1; cow <= row; cow++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int cow = 1; cow < n - row; cow++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
