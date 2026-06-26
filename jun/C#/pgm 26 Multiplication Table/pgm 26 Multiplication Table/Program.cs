using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_26_Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i;
            Console.WriteLine("Enter the Digit");
            n = Convert.ToInt32(Console.ReadLine());
            for(i = 1;i <= 10; i++)
            {
                int Res = i * n;
                Console.WriteLine($"{i} * {n} = {Res}");
            }
            Console.ReadKey();
        }
    }
}
