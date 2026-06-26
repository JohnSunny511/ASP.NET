using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_10_positive_negative_zero
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the Number");
            n = Convert.ToInt32(Console.ReadLine());
            if(n == 0)
            {
                Console.WriteLine("{0} is equal to zero",n);
            }
            else if(n > 0)
            {
                Console.WriteLine("{0} is positive",n);
            }
            else
            {
                Console.WriteLine("{0} is Negative",n);
            }
            Console.ReadKey();
        }
    }
}
