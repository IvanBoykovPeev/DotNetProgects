using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseTwoInteger
{
    class ReverseTwoInteger
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            a = a + b; //a = 15
            b = a - b; //b = 5
            a = a - b; //a = 15 - 5 = 10
            Console.WriteLine("a={0}", a);
            Console.WriteLine("b={0}", b);
        }
    }
}
