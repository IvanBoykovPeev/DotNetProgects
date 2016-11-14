using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBineriConvertor
{
    class DecimalToBineriConvertor
    {
        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int numberBase = 2;
            List<int> outputList = new List<int>();

            if (inputNumber == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                while (inputNumber > 0)
                {
                    outputList.Add(inputNumber % numberBase); //take modul
                    inputNumber = inputNumber / numberBase;   //divide by number base
                }
                outputList.Reverse(); //revers list
                foreach (var digit in outputList)
                {
                    Console.Write(digit);
                }
                Console.WriteLine();
            }
        }
    }
}
