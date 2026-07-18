using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_39_Delegate
{
    public delegate int del(int a, int b);
    class Program
    {
        public int sum(int a,int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Program ob = new Program();
            del d = new del(ob.sum);
            int s = d(10, 20);
            Console.WriteLine("Sum is : {0}", s);
            Console.ReadKey();
        }
    }
}
