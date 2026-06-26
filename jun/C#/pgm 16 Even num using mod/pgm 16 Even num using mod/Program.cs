using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_16_Even_num_using_mod
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i = 1;
            Console.WriteLine("Enter the Limit");
            n = Convert.ToInt32(Console.ReadLine());
            while(i <= n)
            {
                if(i % 2 == 0)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}
