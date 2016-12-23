using System;

namespace _03.PowersOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var power = 1;
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(power);
                power = power * 2;
            }
        }
    }
}
