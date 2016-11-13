using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateFactorial
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            //"decimal" is the biggest type that can hold intger values
            decimal factorial = 1;
            //Perform an "infinite loop"
            while (true)
            {
                if (n <= 1)
                {
                    break;
                }
                factorial *= n;
                n--;
            }
            Console.WriteLine("n! = " + factorial);
        }
    }
}
