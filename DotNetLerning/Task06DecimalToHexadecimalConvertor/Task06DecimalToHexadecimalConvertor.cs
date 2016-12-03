using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06DecimalToHexadecimalConvertor
{
    class Task06DecimalToHexadecimalConvertor
    {
        static void Main()
        {
            uint number = uint.Parse(Console.ReadLine());
            List<string> hexCode = new List<string>();

            do
            {
                uint remainder = number % 16;
                number = number / 16;
                switch (remainder)
                {
                    case 10:
                        hexCode.Add("A");
                        break;
                    case 11:
                        hexCode.Add("B");
                        break;
                    case 12:
                        hexCode.Add("C");
                        break;
                    case 13:
                        hexCode.Add("D");
                        break;
                    case 14:
                        hexCode.Add("E");
                        break;
                    case 15:
                        hexCode.Add("F");
                        break;
                    default:
                        hexCode.Add(remainder.ToString());
                        break;
                }
            } while (number != 0);
            hexCode.Reverse();

            foreach (var digit in hexCode)
            {
                Console.Write(digit);
            }
            Console.WriteLine();
        }
    }
}
