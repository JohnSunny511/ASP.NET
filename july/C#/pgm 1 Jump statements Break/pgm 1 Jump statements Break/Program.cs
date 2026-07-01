using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_1_Jump_statements_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10,i,j;
            for (i = 0; i < n; i++)
            {
                for (j = i; j < n   ; j++)
                {
                    if (j == 3)
                    {
                        Console.WriteLine("Exit our of j Loop");
                        break;
                    }
                    Console.WriteLine(j);
                }
                Console.Write(i);
            }
            Console.ReadKey();
        }
    }
}
