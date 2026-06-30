using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_37___start_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j,x;
            Console.WriteLine("Enter the limit");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                for(x = 1;x < n - i; x++)
                {
                    Console.Write("  ");
                }
                for(j = 0;j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}
