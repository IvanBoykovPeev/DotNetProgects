using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05inaryToDecimalConvertor
{
    class Task05BinaryToDecimalConvertor
    {
        static void Main()
        {
            string bin = Console.ReadLine(); //Read the input like a string
            long decimalNumber = 0;  //variable hold the decimal number
            long multi = 1;
            for (int i = bin.Length - 1; i >= 0; i--)
            {
                if (bin[i] == '0')
                {
                    decimalNumber += 0 * multi;
                }
                if (bin[i] == '1')
                {
                    decimalNumber += 1 * multi;
                }
                multi *= 2;  //for each iteration multi = 2, 4, 6, 8
            }
            Console.WriteLine(decimalNumber);
        }
    }
}
