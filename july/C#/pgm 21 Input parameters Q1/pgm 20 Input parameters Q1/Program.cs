using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_20_Input_parameters_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.sum(2,3);
            int p = obj.pro(2, 3);
            Console.WriteLine($"Product : {p}");
            Console.ReadKey();
        }

        public void sum(int x,int y)
        {
            int s = x + y;
            Console.WriteLine($"{x} + {y} = {s}");

        }

        public int pro(int x, int y)
        {
            int p = x * y;
            return p;
        }
    }
}
