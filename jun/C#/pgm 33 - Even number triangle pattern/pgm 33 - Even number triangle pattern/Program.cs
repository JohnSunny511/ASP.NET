using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_33___Even_number_triangle_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j, a = 2;
            Console.WriteLine("Enter the limit");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i < n; i++)
            {
                for (j = 1; j < i; j++)
                {
                    Console.Write($"{a} ");
                    a += 2;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
