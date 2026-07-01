using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_6_string_reversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string s,rev = "";
            int c = 0,i;
            Console.WriteLine("Enter a string");
            s = Console.ReadLine();
            foreach(char ca in s)
            {
                c++;
            }
            for(i = c-1;i >= 0; i--)
            {
                rev += s[i];
            }
            Console.WriteLine(rev);
            Console.ReadKey();
        }
        
    }
}
