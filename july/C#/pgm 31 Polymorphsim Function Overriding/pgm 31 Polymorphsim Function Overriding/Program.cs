using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_31_Polymorphsim_Function_Overriding
{

    class A
    {
        public virtual void display()
        {
            Console.WriteLine("Base class");
        }
    }
    class Program:A
    {
        public override void display()
        {
            Console.WriteLine("Derived Class");
        }
        static void Main(string[] args)
        {
            Program ob = new Program();
            ob.display();
            Console.ReadKey();
        }
    }
}
