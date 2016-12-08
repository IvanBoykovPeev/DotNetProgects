using System;

namespace _04.GreaterNumber
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter two integer:");
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            if (num1 >= num2)
            {
                Console.WriteLine("Greater number: {0}", num1);
            }
            else
            {
                Console.WriteLine("Greater number: {0}", num2);
            }
        }
    }
}
