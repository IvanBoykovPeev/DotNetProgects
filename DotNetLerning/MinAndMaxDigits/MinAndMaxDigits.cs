using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinAndMaxDigits
{
    class MinAndMaxDigits
    {
        static void Main()
        {
            Console.WriteLine("Number of digits:");
            int numberOfDigits = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < numberOfDigits; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n <= min)
                {
                    min = n;
                }
                else if(n > max)
                {
                    max = n;
                }
            }
            Console.WriteLine("min = " + min);
            Console.WriteLine("max = " + max);
        }
    }
}
