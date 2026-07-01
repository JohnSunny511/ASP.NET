using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_Pgm_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10, i, j;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (i = n - 1; i >= 0; i--)
            {
                for (j = 0; j < n - i + 1; j++)
                {
                    Console.Write(" ");
                }
                for (j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}
