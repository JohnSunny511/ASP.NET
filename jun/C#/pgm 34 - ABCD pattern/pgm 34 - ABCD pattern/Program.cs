using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_34___ABCD_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j, x = 65;
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    Console.Write($"{(char)x} ");
                    x++;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
