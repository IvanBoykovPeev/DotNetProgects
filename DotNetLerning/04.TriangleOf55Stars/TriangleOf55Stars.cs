using System;

namespace _04.TriangleOf55Stars
{
    class TriangleOf55Stars
    {
        static void Main()
        {
            char simbol = '*';
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(new string(simbol, i));                
            }
        }
    }
}
