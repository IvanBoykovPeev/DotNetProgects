using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SquareofStars
{
    class SquareofStars
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            char symbol = '*';
            Console.WriteLine(new string(symbol, n));
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", symbol, new string(' ', n - 2));
            }
            Console.WriteLine(new string(symbol, n));
        }
    }
}
