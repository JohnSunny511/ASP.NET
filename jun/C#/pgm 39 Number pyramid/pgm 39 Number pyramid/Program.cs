using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_39_Number_pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j;
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write("  ");
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j);
                    Console.Write(" ");
                }
                for (j = i-1; j >= 1; j--)
                {
                    Console.Write(j);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
