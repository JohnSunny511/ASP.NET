using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_32___Number_pattern_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j;
            Console.WriteLine("Enter the limit");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write($"{j}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
