using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class CatManipulating
    {
        public static void Main()
        {
            Cat Cat = new Cat();

            Console.WriteLine("The color of cat {0} is {1}.", Cat.Name, Cat.Color);
            Cat.SayMiau();

            Cat myCat = new Cat("Susy", "White");

            Console.WriteLine("The color of cat {0} is {1}.", myCat.Name, myCat.Color);
            myCat.SayMiau();
        }
    }
}
