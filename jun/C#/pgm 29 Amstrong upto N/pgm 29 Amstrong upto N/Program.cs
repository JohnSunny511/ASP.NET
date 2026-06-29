using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_29_Amstrong_upto_N
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, rem, i,count;
            Console.WriteLine("Enter the Limit");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i < n; i++)
            {
                int x = i, am = 0;
                count = i.ToString().Length;
                while (x > 0)
                {
                    rem = x % 10;
                    am += Convert.ToInt32(Math.Pow(rem, count));
                    x /= 10;
                }
                if(am == i)
                {
                    Console.WriteLine(am);
                }
            }
            Console.ReadKey();
        }
    }
}
