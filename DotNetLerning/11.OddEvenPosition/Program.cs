using System;

namespace _11.OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var oddMin = double.MaxValue;
            var oddMax = double.MinValue;
            var oddSum = 0.0;
            var evenMin = double.MaxValue;
            var evenMax = double.MinValue;
            var evenSum = 0.0;

            for (int i = 1; i <= n; i++)
            {

                var num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += num;
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                }
                else
                {
                    oddSum += num;
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }
                }
            }
            var noStr = "No";
            Console.WriteLine("OddSum={0},", oddSum);
            if (oddMin != double.MaxValue)
            {
            Console.WriteLine("OddMin={0},", oddMin);
            }
            else
            {
                Console.WriteLine("OddMin={0},", noStr);
            }
            if (oddMax != double.MinValue)
            {
            Console.WriteLine("OddMax={0},", oddMax);
            }
            else
            {
                Console.WriteLine("OddMax={0},", noStr);
            }


            Console.WriteLine("EvenSum={0},", evenSum);
            if (evenMin != double.MaxValue)
            {
                Console.WriteLine("EvenMin={0},", evenMin);
            }
            else
            {
                Console.WriteLine("EvenMin={0},", noStr);
            }
            if (evenMax != double.MinValue)
            {
                Console.WriteLine("EvenMax={0},", evenMax);
            }
            else
            {
                Console.WriteLine("EvenMax={0}", noStr);
            }

        }
    }
}
