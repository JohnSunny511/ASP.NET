using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_40_Multi_Cast_Delegate
{
    public delegate void del(int a, int b);
    class Program
    {
        public void sum(int a, int b)
        {
            Console.WriteLine($"Sum : {a + b}");
        }

        public void product(int a, int b)
        {
            Console.WriteLine($"Product : {a * b}");
        }
        static void Main(string[] args)
        {
            Program ob = new Program();
            del d = new del(ob.sum);
            d += new del(ob.product);
            d(100, 200);
            Console.ReadKey();
        }
    }
}
