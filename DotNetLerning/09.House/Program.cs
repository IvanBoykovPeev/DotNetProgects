using System;

namespace _09.House
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var starCounrer = 2;

            for (int row = 1; row <= (n + 1) / 2; row++)
            {
                
                if (n % 2 == 0)
                {
                    Console.WriteLine("{0}{1}{0}", new string('-', (n - starCounrer) / 2), 
                        new string('*', starCounrer));                    
                }
                else
                {
                    Console.WriteLine("{0}{1}{0}", new string('-', (n - starCounrer + 1) / 2),
                        new string('*', starCounrer - 1));
                }
                starCounrer += 2;
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("|{0}|", new string('*', n - 2));
            }
        }
    }
}
