using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateFactorialWithDoWhileLoop
{
    class Program
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            decimal factorial = 1;
            do
            {
                factorial *= n;
                n--;
            } while (n > 0);
            Console.WriteLine("n! = " + factorial);
        }
    }
}
