using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_34_Constructors__Default__Parametrized__Static
{
    class A
    {
        public A()
        {
            Console.WriteLine("Default Constructor");

        }

        public A(int x, int y)
        {
            Console.WriteLine($"Sum : {x + y}");
        }

        static A()
        {
            Console.WriteLine("Static Constructor");

        }

        static void Main(string[] args)
        {
            A ob = new A();
            A obj = new A(2, 5);
            Console.ReadKey();
        }
    }
}
