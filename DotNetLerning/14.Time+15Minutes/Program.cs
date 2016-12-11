using System;

namespace _14.Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            minutes += 15;

            if (minutes > 59)
            {
                hours += 1;
                minutes -= 60;
            }
            if (hours > 23)
            {
                hours -= 24;
            }

            if (minutes > 9)
            {
                Console.WriteLine("{0}:{1}", hours, minutes);
            }
            else
            {
                Console.WriteLine("{0}:0{1}", hours, minutes);
            }
        }
    }
}
