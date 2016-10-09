using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.GetMax
{
    class Program
    {
        static int GetMax(int firstNumber, int secondNumber)
        {
            int hightNumber = 0;
            if (firstNumber > secondNumber)
            {
                hightNumber = firstNumber;
                return hightNumber;
            }
            hightNumber = secondNumber;
            return hightNumber;
        }


        static void Main()
        {
            int first = int.Parse(Console.ReadLine());            
            int second = int.Parse(Console.ReadLine());            
            int thirt = int.Parse(Console.ReadLine());
            first = GetMax(first, second);
            first = GetMax(first, thirt);
            Console.WriteLine("{0} is hight of them", first, second);
        }
    }
}
