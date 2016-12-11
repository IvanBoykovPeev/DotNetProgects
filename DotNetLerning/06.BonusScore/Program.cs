using System;

namespace _06.BonusScore
{
    class Program
    {
        static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            double score = 0.0;
            double sum = 0.0;
            if (number < 100)
            {
                score = score + 5;
            }
            else
            {
                if (number > 1000)
                {
                    score = score + number * 0.1;
                }
                else
                {
                    score = score + number * 0.2;
                }
            }


            if (number % 2 == 0)
            {
                score = score + 1;
            }
            else if (number % 5 == 0)
            {
                score = score + 2;
            }


            sum = number + score;
            Console.WriteLine(score);
            Console.WriteLine(sum);
        }
    }
}
