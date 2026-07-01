using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_Pgm_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5,i,j;
            for (i = 1; i <= n; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (i == 1 || i == n || j == 2)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
