using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_9_Reverse_of_words_in_a_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, rev = "";
            string[] arr;
            int i;
            Console.WriteLine("Enter the string");
            s = Console.ReadLine();
            arr = s.Split();
            for (i = arr.Length - 1;i >= 0; i--)
            {
                rev += ' ' + arr[i];
            }
            Console.WriteLine($"Words Reversed: {rev}");
            Console.ReadKey();
        }
    }
}
