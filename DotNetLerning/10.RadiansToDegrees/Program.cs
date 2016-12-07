using System;

namespace _10.RadiansToDegrees
{
    class Program
    {
        static void Main()
        {
            var degrees = double.Parse(Console.ReadLine());
            var radians = degrees * 180 / Math.PI;
            Console.WriteLine(Math.Round(radians));
        }
    }
}
