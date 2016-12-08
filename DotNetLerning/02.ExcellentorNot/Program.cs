using System;

namespace _02.ExcellentorNot
{
    class Program
    {
        static void Main()
        {
            var grade = double.Parse(Console.ReadLine());
            if (grade >= 5.5)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Not excellent.");
            }
        }
    }
}
