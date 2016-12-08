using System;

namespace _03.EvenOrOdd
{
    class Program
    {
        static void Main()
        {
            var even = int.Parse(Console.ReadLine());
            if (even % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
