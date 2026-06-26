using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_25_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i,Res = 1;
            Console.WriteLine("Enter the Number");
            n = Convert.ToInt32(Console.ReadLine());
            for(i = 1;i <= n; i++)
            {
                Res *= i;
            }
            Console.WriteLine(Res);
            Console.ReadKey();
        }

    }
}
