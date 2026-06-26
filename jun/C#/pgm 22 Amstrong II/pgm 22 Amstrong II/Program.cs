using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_22_Amstrong_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, count, x, rem, am = 0;
            Console.WriteLine("Enter the digit");
            n = Convert.ToInt32(Console.ReadLine());
            x = n;
            count = n.ToString().Length;
            while(n > 0)
            {
                rem = n % 10;
                am += Convert.ToInt32(Math.Pow(rem, count));
                n /= 10;
            }
            if(am == x)
            {
                Console.WriteLine("Amstrong");
            }
            else
            {
                Console.WriteLine("Not Amstrong");
            }
            Console.ReadKey(); 
        }
    }
}
