using System;

namespace _07.LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var leftSum = 0;
            var rightSum = 0;

            for (int i = 0; i < n; i++)
            {
                leftSum += int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                rightSum += int.Parse(Console.ReadLine());
            }

            if (Math.Abs(leftSum - rightSum) == 0)
            {
                Console.WriteLine("Yes, sum = " + leftSum);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(leftSum - rightSum));
            }
        }
    }
}
