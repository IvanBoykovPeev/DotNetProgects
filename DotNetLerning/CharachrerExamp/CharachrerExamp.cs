using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharachrerExamp
{
    class CharachrerExamp
    {
        static void Main()
        {
            char symbol = 'a';
            Console.WriteLine("The code of '" + symbol + "' is: " + (int)symbol); //cast char to int show charachter code 

            symbol = 'b';
            Console.WriteLine("The code of '" + symbol + "' is: " + (int)symbol);

            symbol = 'A';
            Console.WriteLine("The code of '" + symbol + "' is: " + (int)symbol);
        }
    }
}
