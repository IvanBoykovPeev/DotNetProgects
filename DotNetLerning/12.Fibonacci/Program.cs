using System;

namespace _12.Fibonacci
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int fibNum = 0;
            if (n < 2)
            {
                fibNum = 1;
            }
            else
            {
                var f0 = 1;
                var f1 = 1;
                for (int i = 1; i < n; i++)
                {
                    fibNum = f0 + f1;
                    f0 = f1;
                    f1 = fibNum;
                }
            }
            Console.WriteLine(fibNum);
        }
    }
}
