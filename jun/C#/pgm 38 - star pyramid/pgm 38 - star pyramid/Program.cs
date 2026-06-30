using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_38___star_pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j;
            Console.WriteLine("Enter the limit");
            n = Convert.ToInt32(Console.ReadLine());
            for(i = 0; i < n; i++)
            {
                for(j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }
                for(j = 0;j <= i; j++)
                {
                    Console.Write("*");
                }
                for(j = 0; j <= i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
