using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_24_Single_Inheritance
{

    class A
    {
        public void displayA()
        {
            Console.WriteLine("Base Class A");

        }
    }

    class B:A
    {

        public void displayB()
        {
            Console.WriteLine("Derived Class B");

        }

        static void Main(string[] args)
        {
            B obj = new B();
            obj.displayA();
            obj.displayB();
            Console.ReadKey();
        }
    }
}
