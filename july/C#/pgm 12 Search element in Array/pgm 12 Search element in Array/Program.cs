using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_12_Search_element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i,x,flag = 0;
            Console.WriteLine("Enter the limit");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the number:");
            for (i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the number to be found");
            x = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                if(arr[i] == x)
                {
                    Console.WriteLine($"{x} is found at index {i}");
                    flag = 1;
                    break;
                }   
            }
            if(flag == 0)
            {
                Console.WriteLine("Element not found");
            }
            Console.ReadKey();
        }
    }
}
