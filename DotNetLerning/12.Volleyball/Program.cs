using System;

namespace _12.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine().ToLower();
            var holidays = int.Parse(Console.ReadLine());
            var weekendsOutOfTown = int.Parse(Console.ReadLine());
            var weekendsInYear = 48;

            double sumDays = ((weekendsInYear - weekendsOutOfTown) * 3.0 / 4)
                + weekendsOutOfTown + (holidays * 2.0 / 3);
            if (year == "leap")
            {
                sumDays += sumDays * 0.15;
                
            }
            Console.WriteLine(Math.Truncate(sumDays));
        }
    }
}
