using System;

namespace _04.TriangleOfDollars
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int cow = 1; cow <= row; cow++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
        }
    }
}
