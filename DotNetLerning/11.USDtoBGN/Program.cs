using System;

namespace _11.USDtoBGN
{
    class Program
    {
        static void Main()
        {
            var dollar = double.Parse(Console.ReadLine());
            var leva = 1.79549;
            var amount = dollar * leva;
            Console.WriteLine(Math.Round(amount, 2));
        }
    }
}
