using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_32_Abstraction
{
    abstract class A
    {
        public void display()
        {
            Console.WriteLine("Non Abstract Method");

        }

        public abstract void absmethod();
    }
    class Program:A
    {
        public override void absmethod()
        {
            Console.WriteLine("Abstract Method");
        }
        static void Main(string[] args)
        {
            Program ob = new Program();
            ob.display();
            ob.absmethod();
            Console.ReadKey();
        }
    }
}
