using System;

namespace _01.HousePrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var room1 = double.Parse(Console.ReadLine());
            var kitchen = double.Parse(Console.ReadLine());
            var price = double.Parse(Console.ReadLine());

            var room2 = room1 + room1 * 0.1;
            var room3 = room2 + room2 * 0.1;
            var bathroom = room1 / 2;

            var sum = room1 + kitchen + room2 + room3 + bathroom;
            sum = sum + sum * 0.05;
            Console.WriteLine("{0:f2}", sum * price);
        }
    }
}
