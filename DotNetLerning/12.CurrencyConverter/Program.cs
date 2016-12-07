using System;

namespace _12.CurrencyConverter
{
    class Program
    {
        static void Main()
        {        
        var amount = double.Parse(Console.ReadLine());
            var currencyInput = Console.ReadLine();
            var currencyOutput = Console.ReadLine();
            var sum = 0.0;
            switch (currencyInput)
            {
                case "BGN":
                    if (currencyOutput == "USD")
                    {
                        sum = amount * 0.55695;
                    }
                    if (currencyOutput == "EUR")
                    {
                        sum = amount * 0.51129;
                    }
                    if (currencyOutput == "GBP")
                    {
                        sum = amount * 0.39462;
                    }
                    break;
                case "EUR":
                    if (currencyOutput == "BGN")
                    {
                        sum = amount * 1.95583;
                    }
                    if (currencyOutput == "USD")
                    {
                        sum = amount * 0.91801;
                    }
                    if (currencyOutput == "GBP")
                    {
                        sum = amount * 0.77181;
                    }
                    break;
                case "USD":
                    if (currencyOutput == "BGN")
                    {
                        sum = amount * 1.79549;
                    }
                    if (currencyOutput == "EUR")
                    {
                        sum = amount * 0.91801;
                    }
                    if (currencyOutput == "GBP")
                    {
                        sum = amount * 0.70854;
                    }
                    break;
                case "GBP":
                    if (currencyOutput == "BGN")
                    {
                        sum = amount * 2.53405;
                    }
                    if (currencyOutput == "USD")
                    {
                        sum = amount * 1.41134;
                    }
                    if (currencyOutput == "EUR")
                    {
                        sum = amount * 1.29563;
                    }
                    break;
                default:
                    break;                    
            }

            Console.WriteLine(Math.Round(sum, 2));
        }
    }
}
