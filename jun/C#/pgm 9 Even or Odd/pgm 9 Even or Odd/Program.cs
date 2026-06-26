using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_9_Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number to be checked");
            n = Convert.ToInt32(Console.ReadLine());
            if(n % 2 == 0)
            {
                Console.WriteLine($"{n} is  an Even Number");
            }
            else
            {
                Console.WriteLine("{0} is an Odd Number", n);
            }
            Console.ReadKey();
        }
    }
}
