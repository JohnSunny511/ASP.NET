using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg_13_while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i=1;
            Console.WriteLine("Enter the limit");
            n = Convert.ToInt32(Console.ReadLine());
            while(i <= n)
            {
                Console.Write("{0}", i);
                if (i < n)
                {
                    Console.Write(", ");
                }
                i += 1;
                
            }
            Console.ReadKey();
        }
    }
}
