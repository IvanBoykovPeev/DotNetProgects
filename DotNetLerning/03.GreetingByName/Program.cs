using System;

namespace _03.GreetingByName
{
    class Program
    {
        static void Main()
        {
            //Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
