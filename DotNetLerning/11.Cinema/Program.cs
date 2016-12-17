using System;

namespace _11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var projection = Console.ReadLine().ToLower();
            var rows = int.Parse(Console.ReadLine());
            var cows = int.Parse(Console.ReadLine());
            var sum = 0.0;

            if (projection == "premiere")
            {
                sum = rows * cows * 12.00;
            }
            else if (projection == "normal")
            {
                sum = rows * cows * 7.50;
            }
            else if (projection == "discount")
            {
                sum = rows * cows * 5.00;
            }
            Console.WriteLine(sum + " leva");
        }
    }
}
