using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04DecimalToBinaryConvertor
{
    class Task04DecimalToBinaryConvertor
    {
        static void Main()
        {
            string inputDecimalNumber = Console.ReadLine();
            long decimalNumber = long.Parse(inputDecimalNumber);

            if (decimalNumber < 0)
            {
                decimalNumber = decimalNumber ^ long.MinValue;
            }

            if (decimalNumber != 0)
            {
                string binaryRepresentation = null;
                while (decimalNumber != 0)
                {
                    byte remainder = (byte)(decimalNumber % 2);
                    binaryRepresentation = remainder + binaryRepresentation;
                    decimalNumber /= 2;
                }
                Console.WriteLine(binaryRepresentation);
            }

            else
            {
                Console.WriteLine(decimalNumber);
            }
        }
    }
}
