using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_51_Factorial_using_Recurrsion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to find factorial");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The factorial of {0} is {1}", n, factorial(n));
            Console.ReadKey();
        }

        static int factorial(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            else
            {
                return num * (factorial(num - 1));
            }
        }
    }
}
