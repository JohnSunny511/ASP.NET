using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg5___Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, s;
            Console.WriteLine("Enter First Number");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Number");
            n2 = Convert.ToInt32(Console.ReadLine());
            s = n1 + n2;
            Console.WriteLine($"sum of {n1} + {n2} = {s}");
            Console.ReadKey();
        }
    }
}
