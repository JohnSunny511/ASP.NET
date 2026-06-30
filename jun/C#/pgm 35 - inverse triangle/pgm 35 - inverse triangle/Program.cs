using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_35___inverse_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j;
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = n; i > 0; i--)
            {
                for (j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
