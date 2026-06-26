using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_17_Reverse_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, res = 0, rem;
            Console.WriteLine("Enter the Number to be Reversed");
            n = Convert.ToInt32(Console.ReadLine());
            while(n > 0)
            {
                rem = n % 10;
                res = res * 10 + rem;
                n = n / 10;
            }
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
