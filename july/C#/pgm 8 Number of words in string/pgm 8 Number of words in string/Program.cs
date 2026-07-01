using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_8_Number_of_words_in_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int i, c = 0;
            Console.WriteLine("Enter the string");
            s = Console.ReadLine();
            if(s.Length == 0)
            {
                Console.WriteLine("0 words");
            }
            else
            {
                for(i = s.Length - 1; i >= 0; i--)
                {
                    if(s[i] == ' ')
                    {
                        c++;
                    }
                }
                Console.WriteLine(c + 1);
            }
            
            Console.ReadKey();
        }
        
    }
}
