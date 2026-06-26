using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_18_Pallindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, res = 0, rem, m;
            Console.WriteLine("Enter the Number");
            n = Convert.ToInt32(Console.ReadLine());
            m = n;
            while(n > 0)
            {
                rem = n % 10;
                res = res * 10 + rem;
                n = n / 10;
            }
            if(res == m)
            {
                Console.WriteLine("It is a palindrome");
            }
            else
            {
                Console.WriteLine("Not a Pallindrome");
            }
            Console.ReadKey();
        }
    }
}
