using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideBy3And7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter digit fron 1 to 100");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0 || n > 100)
            {
                Console.WriteLine("Invalid input");
                return;
            }

            for (int i = 1; i <= n; i++)
            {


                if (i % 21 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
