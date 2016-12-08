using System;
using System.Globalization;

namespace _13._1000_DaysAfterBirth
{
    class Program
    {
        static void Main()
        {
            var date = Console.ReadLine();
            var format = "dd-MM-yyyy";
            var dateAfter = DateTime.ParseExact(date, format, CultureInfo.CurrentCulture);
            dateAfter = dateAfter.AddDays(999);
            Console.WriteLine(dateAfter.ToString(format));
        }
    }
}
