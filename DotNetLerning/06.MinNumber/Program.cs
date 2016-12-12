using System;

namespace _05.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var max = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number < max)
                {
                    max = number;
                }
            }
            Console.WriteLine(max);
        }
    }
}

