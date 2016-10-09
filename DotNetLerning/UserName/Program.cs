using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserName
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            PrintUserName(name);
        }

        static void PrintUserName(string name)
        {
            Console.WriteLine("Hello {0}!", name);
        }
    }
}
