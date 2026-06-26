using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm1
{
   class P
    {
        public static void Main()
        {
            int n = 5;
            Console.WriteLine(n);

            int n1 = 5, n2 = 10, s;
            s = n1 + n2;
            Console.WriteLine("Sum is: " + s);
            Console.WriteLine("Sum is:  {0}",s);
            Console.WriteLine("Sum of {0} and {1} is {2}", n1, n2, s);
            Console.WriteLine($"{n1} + {n2} = {s}");

            Console.ReadKey(false);

        }
    }
}
