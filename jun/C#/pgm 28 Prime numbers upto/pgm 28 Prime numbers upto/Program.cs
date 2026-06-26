using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_28_Prime_numbers_upto
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i,c = 0,j;
            Console.WriteLine("Enter the limit");
            n = Convert.ToInt32(Console.ReadLine());
            for(i = 2;i <= n; i++)
            {
                for(j = 1;j <= i; j++)
                {
                    if(i % j == 0)
                    {
                        c++;
                    }
                }
                if(c < 3)
                {
                    Console.WriteLine(i);
                }
                c = 0;
            }
            Console.ReadKey();
        }
    }
}
