using System;

namespace _10.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var max = 0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num > max)
                {
                    sum += max;
                    max = num;
                }
                else
                {
                sum += num;
                }
            }

            if (max == sum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", sum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(Math.Max(max, sum) - Math.Min(max, sum)));
            }
        }
    }
}
