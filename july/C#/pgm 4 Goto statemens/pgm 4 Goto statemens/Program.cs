using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_4_Goto_statemens
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            switch (n)
            {
                case 1:
                    Console.WriteLine("C#");
                    break;
                case 2:
                    Console.WriteLine("Java");
                    break;
                case 3:
                    Console.WriteLine("Python");
                    goto case 1;
                default:
                    Console.WriteLine("Wron input");
                    break;
            }
            Console.ReadKey();
        }
    }
}
