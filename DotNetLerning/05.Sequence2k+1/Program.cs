using System;

namespace _05.Sequence2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sequence = 1;
            for (int i = 1; sequence <= n; i++)
            {
                Console.WriteLine(sequence);
                sequence = (sequence * 2) + 1;
            }
        }
    }
}
