using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_11_no_of_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the Number");
            n = Convert.ToInt32(Console.ReadLine());
            if(n >= 0 && n <= 9){
                Console.WriteLine($"{n} is a single digit number");
            }
            else if(n >= 10 && n <= 99)
            {
                Console.WriteLine($"{n} is a double digit number");
            }
            else if(n >= 100 && n<= 999)
            {
                Console.WriteLine($"{n} is 3 digit number");
            }
            else
            {
                Console.WriteLine("It is more than 3 digit");
            }
            Console.ReadKey();
        }
    }
}
