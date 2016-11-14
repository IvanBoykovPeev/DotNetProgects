using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            string binaryNumber = Console.ReadLine();
            char[] charArray = binaryNumber.ToCharArray();
            Array.Reverse(charArray);

            double decimalNumber = 0.0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == '1')
                {
                    decimalNumber += Math.Pow((double)2, (double)i);
                }
            }
            Console.WriteLine(decimalNumber);
        }
    }
}
