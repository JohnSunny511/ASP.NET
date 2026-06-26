using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_24_For_loop_Natural_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i;
            Console.Write("enter the limit: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1;i <= n; i++)
            {
                Console.Write($"{i} ");
            }
            Console.ReadKey();
        }
    }
}
