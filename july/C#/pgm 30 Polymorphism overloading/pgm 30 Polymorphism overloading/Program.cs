using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_30_Polymorphism_overloading
{

    class A
    {
        public void sum()
        {
            int s, a = 5, b = 10;
            s = a + b;
            Console.WriteLine("Sum1 : {0}",s);
        }

        public void sum(int x, int y)
        {
            int s = x + y;
            Console.WriteLine("Sum2 : {0}", s);
        }

        public void sum(double x,double y)
        {
            double s = x + y;
            Console.WriteLine("Sum3 : {0}", s);
        }
    }
    class Program:A
    {
        static void Main(string[] args)
        {
            Program ob = new Program();
            ob.sum();
            Console.WriteLine("Enter two integers");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            ob.sum(x,y);
            Console.WriteLine("Enter two Numbers");
            double m = Convert.ToInt32(Console.ReadLine());
            double n = Convert.ToInt32(Console.ReadLine());
            ob.sum(m,n);
            Console.ReadKey();
        }
    }
}
