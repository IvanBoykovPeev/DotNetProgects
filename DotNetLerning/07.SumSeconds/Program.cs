using System;

namespace _07.SumSeconds
{
    class Program
    {
        static void Main()
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());
            var sum = num1 + num2 + num3;
            if (sum <= 59)
            {
                if (sum < 10)
                {
                    Console.WriteLine("0:0{0}", sum);
                }
                else
                {
                    Console.WriteLine("0:{0}", sum);
                }
            }
            else if (sum <= 119)
            {
                sum = sum - 60;
                if (sum < 10)
                {
                    Console.WriteLine("1:0{0}", sum);
                }
                else
                {
                Console.WriteLine("1:{0}", sum);
                }
            }
            else if (sum <= 179)
            {
                sum = sum - 120;
                if (sum < 10)
                {
                    Console.WriteLine("2:0{0}", sum);
                }
                else
                {
                    Console.WriteLine("2:{0}", sum);
                }
            }
        }
    }
}
