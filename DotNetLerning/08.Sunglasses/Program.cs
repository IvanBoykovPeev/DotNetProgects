using System;

namespace _08.Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var star = '*';
            var space = ' ';
            var backslash = '/';
            var straightline = '|';

            Console.WriteLine("{0}{1}{0}", new string(star, 2 * n), new string(space, n));

            for (int row = 0; row < n - 2; row++)
            {
                if (row == (n - 1) / 2 - 1)
                {
                    Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}",
                    star, new string(backslash, 2 * n - 2), new string(straightline, n));
                }

                else
                {
                    Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}",
                        star, new string(backslash, 2 * n - 2), new string(space, n));
                }
            }
            Console.WriteLine("{0}{1}{0}", new string(star, 2 * n), new string(space, n));
        }
    }
}

