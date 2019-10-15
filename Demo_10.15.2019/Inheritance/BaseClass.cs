using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class BaseClass
    {
        // fields: demo field inheritance
        // private vs. protected access modifiers
        private int basePrivateInt;
        protected int baseProtectedInt;

        // constructors (in assistance to field inheritance demo)

        // this is the default constructor:
        public BaseClass() { }

        // this is a master constructor?
        public BaseClass(int privateInt, int protectedInt)
        {
            // this keyword refers previously set
            this.basePrivateInt = privateInt;
            this.baseProtectedInt = protectedInt;
        }

        // methods
        public void BaseMethod()
        {
            Console.WriteLine("BaseClass.BaseMethod");
        }

        // prints items
        // see ChildClass.cs Prinstate() *virtual/override keywords*
        public virtual void PrintState()
        {
            Console.WriteLine("BaseClass object");
            Console.WriteLine("\tbasePrivateInt: {0}", basePrivateInt);
            Console.WriteLine("\tbaseProtectedInt: {0}", baseProtectedInt);
        }
    }
}
