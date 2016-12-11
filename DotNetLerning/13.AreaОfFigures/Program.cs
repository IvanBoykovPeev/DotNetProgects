using System;

namespace _13.AreaОfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            var area = 0.0;

            if (figure == "square")
            {
                var side = double.Parse(Console.ReadLine());
                area = side * side;
            }
            else if (figure == "rectangle")
            {
                var width = double.Parse(Console.ReadLine());
                var hight = double.Parse(Console.ReadLine());
                area = width * hight;
            }
            else if (figure == "circle")
            {
                var radius = double.Parse(Console.ReadLine());
                area = Math.PI * radius * radius;
            }
            else if (figure == "triangle")
            {
                var aSide = double.Parse(Console.ReadLine());
                var hight = double.Parse(Console.ReadLine());
                area = (aSide * hight) / 2;
            }

            Console.WriteLine(Math.Round(area, 3));
        }
    }
}
