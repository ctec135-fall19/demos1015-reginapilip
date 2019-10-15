using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class ChildClass : BaseClass
    {
        // fields
        protected int childProtectedInt;

        //constructors
        public ChildClass() { }
        public ChildClass(int basePrivateInt, int baseProtectedInt, 
            int ChildProtectedInt) 
            // calls constructor from base class
            : base(basePrivateInt, baseProtectedInt)
        {
            this.childProtectedInt = childProtectedInt;
        }

        // methods
        public void ChildMethod()
        {
            Console.WriteLine("ChildClass.ChildMethod");
        }

        // virtual modifier allows you to override the base level method
        // with the child level method
        // no hiding necessary
        public override void PrintState()
        {
            Console.WriteLine("ChildClass object");
            // Console.WriteLine("\tbasePrivateInt: {0}", basePrivateInt); 
            // this private int, child class doesn't have access to it 
            // Console.WriteLine("\tbaseProtectedInt: {0}", baseProtectedInt);
            // however, for the protected int it does
            Console.WriteLine("\tchildProtectedInt: {0}", childProtectedInt);
            base.PrintState();
        }
    }
}
