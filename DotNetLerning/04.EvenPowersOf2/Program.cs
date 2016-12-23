using System;

namespace _04.EvenPowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var power = 1;
            for (int i = 0; i <= n; i+=2)
            {
                Console.WriteLine(power);
                power = power * 2 * 2;
            }
        }
    }
}
