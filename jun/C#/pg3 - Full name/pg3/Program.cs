using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, m, l;
            Console.WriteLine("Enter your First Name");
            s = Console.ReadLine();
            Console.Write("Enter your Middle Name");
            m = Console.ReadLine();
            Console.WriteLine("Enter your Last Name");
            l = Console.ReadLine();
            Console.WriteLine($"Full Nmae is {s} {m} {l}");
            Console.ReadKey();
        }
    }
}
