using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUMnumbers1ToN
{
    class Program
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            int sum = 1;
            Console.WriteLine("The sun 1");
            while (num < n)
            {
                num++;
                sum += num;
                Console.Write(" + " + num);
            }
            Console.WriteLine(" = " + sum);
        }
    }
}
