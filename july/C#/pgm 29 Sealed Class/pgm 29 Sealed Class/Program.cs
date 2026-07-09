using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_29_Sealed_Class
{


    sealed class A
    {
        public void display()
        {
            Console.WriteLine("Sealed class Method");
        }
    }
    class B
    {
        static void Main(string[] args)
        {
            A ob = new A();
            ob.display();
            Console.ReadLine();

        }
    }
}
