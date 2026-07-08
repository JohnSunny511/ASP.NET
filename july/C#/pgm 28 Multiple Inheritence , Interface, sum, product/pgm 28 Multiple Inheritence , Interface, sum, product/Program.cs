using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_28_Multiple_Inheritence___Interface__sum__product
{

    interface A
    {
        void sum(int x, int y);
    }

    class B
    {
        public int product(int x, int y)
        {
            int p = x * y;
            return p;
        }
    }
    class C:B,A
    {
        public void sum(int x,int y)
        {
            int s = x + y;
            Console.WriteLine($"Sum : {s}");
        }

        
        static void Main(string[] args)
        {
            C ob = new C();
            Console.WriteLine("Enter two numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            ob.sum(a,b);
            int res = ob.product(a, b);
            Console.WriteLine($"Product : {res}");
            Console.ReadKey();

        }
    }
}
