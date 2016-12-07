using System;

namespace _07._2DRectangleArea
{
    class Program
    {
        static void Main()
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var width = Math.Max(x1, x2) - Math.Min(x1, x2);
            var hight = Math.Max(y1, y2) - Math.Min(y1, y2);
            var area = width * hight;
            var perimeter = 2 * (width + hight);
            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
