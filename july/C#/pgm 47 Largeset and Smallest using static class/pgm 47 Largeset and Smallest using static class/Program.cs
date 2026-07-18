using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_47_Largeset_and_Smallest_using_static_class
{
    static class Test
    {
        public static int Largest(params int[] ar)
        {
            int Great = ar[0];
            for (int i = 1; i < ar.Length; i++)
            {
                if (ar[i] > Great)
                {
                    Great = ar[i];
                }
            }
            return Great;
        }

        public static int Smallest(params int[] ar)
        {
            int small = ar[0];
            for (int i = 1; i < ar.Length; i++)
            {
                if (ar[i] < small)
                {
                    small = ar[i];
                }
            }
            return small;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { 2, 65, 7, 23, 83, 55 };
            int l = Test.Largest(ar);
            int s = Test.Smallest(ar);
            Console.WriteLine($"Largest: {l} \nSmallest: {s}");
            Console.ReadKey();
        }
    }
}
