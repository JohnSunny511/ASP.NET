using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_36_Start_pattern_IV_inverse_and_normal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j;
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {

                for(j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (i = n-1; i >= 0; i--)
            {

                for (j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
