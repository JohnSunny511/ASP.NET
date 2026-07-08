
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_25_Find_sum_using_inheritance
{

    class A
    {
        public int a, b;    // Declared as public outside function and inside class since we cannot make variables inside a class as public , it is alwasys private to the fucntion
        public void read()
        {
            Console.WriteLine("Enter two number");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
        }
    }
    class B:A
    {
        public void sum()
        {
            Console.WriteLine("Sum : {0}", a+b);
        }

        public static void Main(string[] args)
        {
            B ob = new B();
            ob.read();
            ob.sum();
            Console.ReadKey();

        }
    }
}
