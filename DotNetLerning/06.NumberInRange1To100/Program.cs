using System;

namespace _06.NumberInRange1To100
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number in the range [0...100]: ");
            var n = int.Parse(Console.ReadLine());
            while (n < 1 || n > 100)
            {
                Console.WriteLine("Invalid number!");
                Console.Write("Enter a number in the range [0...100]: ");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The number is: {0}", n);
        }
    }
}
