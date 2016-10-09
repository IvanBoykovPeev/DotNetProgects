using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    class TemperatureConverter
    {
        static double ConvertFarenheitToCelsius(double temperatureF)
        {
            double temperatureC = (temperatureF - 32) * 5 / 9;
            return temperatureC;
        }


        static void Main()
        {
            Console.Write("Enter your bpdy temperature in Farenhit degrees: ");
            double temperature = double.Parse(Console.ReadLine());
            temperature = ConvertFarenheitToCelsius(temperature);

            Console.WriteLine("Your body temperature in Celsius degree is {0}.", temperature);

            if (temperature >= 37)
            {
                Console.WriteLine("You are ill!");
            }
        }
    }
}
