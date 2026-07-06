using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_18_Factorial_using_int_function
{
    class Program
    {
        static void Main(string[] args)
        {
            Program ob = new Program();
            int res = ob.fact();
            Console.WriteLine($"Factorial = {res}");
            Console.ReadKey();
        }

        public int fact()
        {
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine()), res = 1;
            for (int i = 1; i <= n; i++)
            {
                res *= i;
            }

            return res;
        }
    }
}
