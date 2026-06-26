using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_27_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i,c = 0;
            Console.WriteLine("Enter the Number");
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("Not defined");
            }
            else
            {
                for (i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        c++;
                        break;
                    }
                }
                if (c > 0)
                {
                    Console.WriteLine("Not Prime");
                }
                else
                {
                    Console.WriteLine("Prime Number");
                }
            }
            Console.ReadKey();
        }
    }
}
