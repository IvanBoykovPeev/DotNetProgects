﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductNToM
{
    class Program
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());
            int num = n;
            long product = 1;

            do
            {
                product *= num;
                num++;
            } while (num <= m);
            Console.WriteLine("product [n..m] = " + product);
        }
    }
}
