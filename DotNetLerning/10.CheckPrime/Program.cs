using System;

namespace _10.CheckPrime
{
    class Program
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (num < 2)
            {
                isPrime = false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}
