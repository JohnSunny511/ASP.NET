using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_7_String_Pallindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, rev = "";
            Console.WriteLine("Enter the string");
            s = Console.ReadLine();
            for(int i = s.Length-1; i >= 0; i--)
            {
                rev += s[i];
            }
            if(rev == s)
            {
                Console.WriteLine("It's a pallindrome");
            }
            else
            {
                Console.WriteLine("It's Not  a Pallindrome");
            }
            Console.ReadKey();
        }
    }
}
