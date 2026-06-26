using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_15_Odd_Numbers_using_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i = 1;
            Console.WriteLine("Enter the Limit");
            n = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write("{0}", i);
                if (i < n-1)
                {
                    Console.Write(", ");
                }
                i += 2;
            } while (i <= n);
            Console.ReadKey();
        }
    }
}
