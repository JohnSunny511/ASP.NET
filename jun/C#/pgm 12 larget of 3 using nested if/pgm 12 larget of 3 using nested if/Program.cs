using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_12_larget_of_3_using_nested_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter the three numbers to compare");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if(a > b)
            {
                if(a > c)
                {
                    Console.WriteLine($"{a} is the greatest number");
                }
                else
                {
                    Console.WriteLine($"{c} is greatest");
                }
            }
            else
            {
                if(b > c)
                {
                    Console.WriteLine($"{b} is greatest");
                }
                else
                {
                    Console.WriteLine($"{c} is greatest");
                }
            }
            Console.ReadKey();
        }
    }
}
