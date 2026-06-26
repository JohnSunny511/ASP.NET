using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_20_Count_number_of_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, c = 0;
            Console.WriteLine("Enter the digit");
            n = Convert.ToInt32(Console.ReadLine());
            while(n > 0)
            {
                c++;
                n = n / 10;
            }
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
