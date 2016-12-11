using System;

namespace _08.MetricConverter
{
    class Program
    {
        static void Main()
        {
            var number = double.Parse(Console.ReadLine());
            string convertIn = Console.ReadLine();
            string convertOut = Console.ReadLine();

            double sum = 0.0;

            //revers input to meters
            if (convertIn == "mm")
            {
                sum = number / 1000.0;
            }
            else if (convertIn == "cm")
            {
                sum = number / 100.0;
            }
            else if (convertIn == "mi")
            {
                sum = number / 0.000621371192;
            }
            else if (convertIn == "in")
            {
                sum = number / 39.3700787;
            }
            else if (convertIn == "km")
            {
                sum = number / 0.001;
            }
            else if (convertIn == "ft")
            {
                sum = number / 3.2808399;
            }
            else if (convertIn == "yd")
            {
                sum = number / 1.0936133;
            }
            else
            {
                sum = number;
            }


            if (convertOut == "mm")
            {
                sum = sum * 1000.0;
            }
            else if (convertOut == "cm")
            {
                sum = sum * 100.0;
            }
            else if (convertOut == "mi")
            {
                sum = sum * 0.000621371192;
            }
            else if (convertOut == "in")
            {
                sum = sum * 39.3700787;
            }
            else if (convertOut == "km")
            {
                sum = sum * 0.001;
            }
            else if (convertOut == "ft")
            {
                sum = sum * 3.2808399;
            }
            else if (convertOut == "yd")
            {
                sum = sum * 1.0936133;
            }

            Console.WriteLine("{0} {1}", sum, convertOut);
        }
    }
}
