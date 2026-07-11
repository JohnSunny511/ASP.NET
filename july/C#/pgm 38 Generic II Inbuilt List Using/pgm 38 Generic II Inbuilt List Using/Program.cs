using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_38_Generic_II_Inbuilt_List_Using
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            List<int> ob = new List<int> { 1, 2, 3, 4, 5 };
            foreach (int i in ob)
            {
                s += i;
            }
            Console.WriteLine("Total: {0}", s);
            Console.ReadKey();
        }
    }
}
