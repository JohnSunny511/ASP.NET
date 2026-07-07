using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_22_Parameter_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Program ob = new Program();
            int[] arr = { 2,4,6,8 };
            ob.display(arr);
            Console.ReadKey();
        }

        public void display(params int [] arr)
        {
            Console.WriteLine("Arary using for loop");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);

            }

            Console.WriteLine("Array using Foreach");

            foreach (int j in arr)    // j takes each element in the array, it doesnt represents each element not index
            {
                Console.WriteLine(j);

            }
        }
    }
}
