using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_2_Continue_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5, i, j;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if(j == 3)
                    {
                        continue;
                    }
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
