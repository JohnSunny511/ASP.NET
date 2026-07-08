using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_26_Sum_and_Average_using_Multilevel_Inheritance
{

    class A
    {
        public double a, b;
        public void read()
        {
            Console.WriteLine("Enter the numbers");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
        }
    }

    class B : A
    {
        public double s;
        public void sum()
        {
            s = a + b;
            Console.WriteLine("Sum : {0}", s);

        }
    }
    class C:B
    {
        public void Avg()
        {
            double Avg = s / 2;
            Console.WriteLine($"Average : {Avg}");
        }
        static void Main(string[] args)
        {
            C ob = new C();
            ob.read();
            ob.sum();
            ob.Avg();
            Console.ReadKey();
        }
    }
}
