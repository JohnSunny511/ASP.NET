using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_3_switch_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1 ;
            switch (n)
            {
                case 1:
                    Console.WriteLine("C#");
                    break;
                case 2:
                    Console.WriteLine("Python");
                    break;
                case 3:
                    Console.WriteLine("Java");
                    break;
                default:
                    Console.WriteLine("C");
                    break;
            }
            Console.ReadKey();
        }
    }
}
