using System;

namespace _09.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10; 
            }
            Console.WriteLine(sum);
        }
    }
}
