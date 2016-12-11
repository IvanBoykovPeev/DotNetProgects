using System;

namespace _16.Number0._._._100ToText
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            if (number < 0 || number > 100)
            {
                Console.WriteLine("invalid number");
            }
            else if (number == 100)
            {
                Console.WriteLine("one hundred");
            }
            else
            {
                var digit = number % 10;
                number = number / 10;
                var dec = number % 10;

                if (dec == 9)
                {
                    Console.Write("ninety");
                }
                else if (dec == 8)
                {
                    Console.Write("eighty");
                }
                else if (dec == 7)
                {
                    Console.Write("seventy");
                }
                else if (dec == 6)
                {
                    Console.Write("sixty");
                }
                else if (dec == 5)
                {
                    Console.Write("fifty");
                }
                else if (dec == 4)
                {
                    Console.Write("fourty");
                }
                else if (dec == 3)
                {
                    Console.Write("thirty");
                }
                else if (dec == 2)
                {
                    Console.Write("twenty");
                }
                else if (dec == 1)
                {
                    if (digit == 1)
                    {
                        Console.WriteLine("eleven");
                    }
                    else if (digit == 2)
                    {
                        Console.WriteLine("twelve");
                    }
                    else if (digit == 3)
                    {
                        Console.WriteLine("thirteen");
                    }
                    else if (digit == 4)
                    {
                        Console.WriteLine("fourteen");
                    }
                    else if (digit == 5)
                    {
                        Console.WriteLine("fifteen");
                    }
                    else if (digit == 6)
                    {
                        Console.WriteLine("sixteen");
                    }
                    else if (digit == 7)
                    {
                        Console.WriteLine("seventeen");
                    }
                    else if (digit == 8)
                    {
                        Console.WriteLine("eighteen");
                    }
                    else if (digit == 9)
                    {
                        Console.WriteLine("nineteen");
                    }
                    else if (digit == 0)
                    {
                        Console.WriteLine("ten");
                    }
                }
                else if (dec == 0)
                {
                    if (digit == 0)
                    {
                        Console.WriteLine("zero");
                    }
                    else if (digit == 1)
                    {
                        Console.WriteLine("one");
                    }
                    else if (digit == 2)
                    {
                        Console.WriteLine("two");
                    }
                    else if (digit == 3)
                    {
                        Console.WriteLine("three");
                    }
                    else if (digit == 4)
                    {
                        Console.WriteLine("four");
                    }
                    else if (digit == 5)
                    {
                        Console.WriteLine("five");
                    }
                    else if (digit == 6)
                    {
                        Console.WriteLine("six");
                    }
                    else if (digit == 7)
                    {
                        Console.WriteLine("seven");
                    }
                    else if (digit == 8)
                    {
                        Console.WriteLine("eight");
                    }
                    else if (digit == 9)
                    {
                        Console.WriteLine("nine");
                    }
                }


                if (dec > 1)
                {
                    if (digit == 1)
                    {
                        Console.WriteLine(" one");
                    }
                    else if (digit == 2)
                    {
                        Console.WriteLine(" two");
                    }
                    else if (digit == 3)
                    {
                        Console.WriteLine(" three");
                    }
                    else if (digit == 4)
                    {
                        Console.WriteLine(" four");
                    }
                    else if (digit == 5)
                    {
                        Console.WriteLine(" five");
                    }
                    else if (digit == 6)
                    {
                        Console.WriteLine(" six");
                    }
                    else if (digit == 7)
                    {
                        Console.WriteLine(" seven");
                    }
                    else if (digit == 8)
                    {
                        Console.WriteLine(" eight");
                    }
                    else if (digit == 9)
                    {
                        Console.WriteLine(" nine");
                    }
                    else if (digit == 0)
                    {
                        Console.WriteLine("");
                    }
                }
            }
        }
    }
}
