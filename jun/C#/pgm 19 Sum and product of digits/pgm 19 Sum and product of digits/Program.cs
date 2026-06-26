using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_19_Sum_and_product_of_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, rem, ad = 0, pro = 1;
            Console.WriteLine("Enter the digit");
            n = Convert.ToInt32(Console.ReadLine());
            while(n > 0)
            {
                rem = n % 10;
                ad += rem;
                pro *= rem;
                n /= 10;
            }
            Console.WriteLine("Sum = {0}", ad);
            Console.WriteLine("Product = {0}", pro);
            Console.ReadKey();
        }
    }
}
