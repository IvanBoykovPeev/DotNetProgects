using System;

namespace _05.RectangleArea
{
    class RectangleArea
    {
        static void Main()
        {
            var a = decimal.Parse(Console.ReadLine());
            var b = decimal.Parse(Console.ReadLine());
            var rectangleArea = a * b;
            Console.WriteLine(rectangleArea);
        }
    }
}
