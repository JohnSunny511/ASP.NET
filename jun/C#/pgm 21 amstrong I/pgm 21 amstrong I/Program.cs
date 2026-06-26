using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_21_amstrong_I
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, rem, m, q = 0, am = 0;
            Console.WriteLine("Enter the digit");
            n = Convert.ToInt32(Console.ReadLine());
            m = n;
            while (n > 0)
            {
                rem = n % 10;
                am += rem * rem * rem;
                n /= 10;
            }
            if(m == am)
            {
                Console.WriteLine("It is Amstrong Number");
            }
            else
            {
                Console.WriteLine("Not an Amstrong Number");
            }
            Console.ReadKey();
        }
    }
}
