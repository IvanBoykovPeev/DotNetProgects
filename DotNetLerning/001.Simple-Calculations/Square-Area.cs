using System;

namespace SquareArea
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("a = ");
            var a = int.Parse(Console.ReadLine());
            var area = a * a;
            Console.Write("Square = ");
            Console.WriteLine(area);
        }
    }
}
