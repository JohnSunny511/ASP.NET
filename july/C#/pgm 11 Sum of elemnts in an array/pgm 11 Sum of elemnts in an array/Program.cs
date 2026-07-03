using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_11_Sum_of_elemnts_in_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i,s = 0;
            Console.WriteLine("Enter the limit");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the number:");
            for (i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                s += arr[i];
            }
            Console.WriteLine($"Sum of elemnts are: {s}");
            Console.ReadKey();
        }
    }
}
