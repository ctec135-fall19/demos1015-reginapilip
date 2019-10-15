using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // test method inheritance
            // cc is not a great variable name... best option would have been childClass
            // the last part "ChildClass()" invokes the default constructor
            ChildClass cc = new ChildClass();
            GrandChildClass1 gcc = new GrandChildClass1();

            Console.WriteLine("calling methods from gcc\n");
            gcc.BaseMethod();
            gcc.ChildMethod();
            gcc.GrandChildMethod();
            Console.WriteLine("===================================\n");

            Console.WriteLine("calling methods from cc\n");
            cc.BaseMethod();
            cc.ChildMethod();
            // you cannot call GrandChild() method here. can only call methods from class or parent classes
            Console.WriteLine("===================================\n");

            // test base class fields
            BaseClass bc = new BaseClass(1234, 456);
            bc.PrintState();
            Console.WriteLine("===================================\n");

            // test child print state
            ChildClass cc2 = new ChildClass(987, 654, 345);
            cc2.PrintState();
            Console.WriteLine("===================================\n");

        }
    }
}
