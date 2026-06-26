using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_14_Even_numbers_upto_N
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i = 2;
            Console.WriteLine("Enter the Limit");
            n = Convert.ToInt32(Console.ReadLine());
            while(i <= n)
            {
                Console.Write("{0}", i);
                if(i < n)
                {
                    Console.Write(", ");
                }
                i += 2;
            }
            Console.ReadKey();
        }
    }
}
