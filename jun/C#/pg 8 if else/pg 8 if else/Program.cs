using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg_8_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the first Number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine($"{a} is the Largest Number");
            }
            else
            {
                Console.WriteLine($"{b} is the largest");
            }
            Console.ReadKey();
        }
    }
}
