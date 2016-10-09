using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleForDelegat
{
    //Declaration of delegate
    public delegate void SimpleDelegate(string aParam);

    class TestDelegate
    {
        public static void TestFunction(string aParam)
        {
            Console.WriteLine("I was called by a delegate.");
            Console.WriteLine("I got parameter {0}.", aParam);
        }        

        static void Main()
        {
            //Instantion of a delegate
            SimpleDelegate simpleDelegate = new SimpleDelegate(TestFunction);
            //Invocation of the method, pointed by a delegate
            simpleDelegate("test");
        }
    }
}
