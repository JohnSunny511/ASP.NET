using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_27_Hierarchical_Inheritance__sum_Avg_Product
{
    class A
    {
        public int a, b;
        public void read()
        {
            Console.WriteLine("Enter two digits");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
        }
    }

    class B:A
    {
        public int s;
        public void sum()
        {
            s = a + b;
            Console.WriteLine($"Sum : {s}");

        }
    }

    class C : A
    {
        public int avg;
        public void averge()
        {
            avg = (a + b) / 2;
            Console.WriteLine("Average : {0}", avg);

        }
    }
    class D:A
    {
        public void product()
        {
            int pro = a * b;
            Console.WriteLine($"Product : {pro}");
        }
        static void Main(string[] args)
        {
            D ob1 = new D();
            C ob2 = new C();
            B ob3 = new B();
            ob1.read();
            ob1.product();
            ob2.read();          // read() is called each time since the earlier read() only reads to that specific class, not other classes
            ob2.averge();
            ob3.read();
            ob3.sum();
            Console.ReadKey();
        }
    }
}
