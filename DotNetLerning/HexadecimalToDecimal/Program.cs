using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalToDecimal
{
    class Program
    {
        static void Main()
        {
            string HexNumber = Console.ReadLine();

            char[] charArray = HexNumber.ToCharArray();
            Array.Reverse(charArray);

            int[] digitArray = new int[charArray.Length];

            for (int i = 0; i < charArray.Length; i++)
            {
                switch (charArray[i])
                {
                    case '0':
                        digitArray[i] = 0; break;
                    case '1':
                        digitArray[i] = 1; break;
                    case '2':
                        digitArray[i] = 2; break;
                    case '3':
                        digitArray[i] = 3; break;
                    case '4':
                        digitArray[i] = 4; break;
                    case '5':
                        digitArray[i] = 5; break;
                    case '6':
                        digitArray[i] = 6; break;
                    case '7':
                        digitArray[i] = 7; break;
                    case '8':
                        digitArray[i] = 8; break;
                    case '9':
                        digitArray[i] = 9; break;
                    case 'A':
                        digitArray[i] = 10; break;
                    case 'B':
                        digitArray[i] = 11; break;
                    case 'C':
                        digitArray[i] = 12; break;
                    case 'D':
                        digitArray[i] = 13; break;
                    case 'E':
                        digitArray[i] = 14; break;
                    case 'F':
                        digitArray[i] = 15; break;
                    default: break;
                }
            }

            double decimalNumber = 0.0;

            for (int i = 0; i < charArray.Length; i++)
            {
                decimalNumber += (double)digitArray[i] * Math.Pow((double)16, (double)i);
            }

            Console.WriteLine(decimalNumber);
        }
    }
}
