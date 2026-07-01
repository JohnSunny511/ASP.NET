using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_5_Goto_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
   check:   Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            if(n == 0)
            {
                goto check;
            }
            else
            {
                Console.WriteLine($"Entered number: {n}");
            }
            Console.ReadKey();
        }
    }
}
