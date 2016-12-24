using System;

namespace _13.NumberPyramid
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var currentNum = 1;
            int row = 1;

            while (currentNum <= n)
            {
                for (int i = 1; i <= row; i++)
                {
                    Console.Write(currentNum + " ");
                    currentNum++;
                    if (currentNum > n)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                if (currentNum > n)
                {
                    break;
                }
                row++;
            }
        }
    }
}
