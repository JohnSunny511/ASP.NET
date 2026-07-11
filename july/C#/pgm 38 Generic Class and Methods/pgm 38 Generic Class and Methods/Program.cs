using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_38_Generic_Class_and_Methods
{
    public class gen<x, y>    //for setting datatype x and y is used
    {
        public x a;  // here x will be changed to a datatype name passed from main function,   "int a"
        public y b;

        public gen(x i, y j)   // i and j of datatype x and y
        {
            a = i;
            b = j;
        }
    }
    class A
    {
        static void Main(string[] args)
        {
            gen<int, int> obj1 = new gen<int, int>(10, 20);
            Console.WriteLine("Sum : {0}", obj1.a + obj1.b);

            gen<string, string> obj2 = new gen<string, string>("Good", " Morning");
            Console.WriteLine($"Concatenated:{obj2.a + obj2.b}");
            Console.ReadKey();
        }
    }
}
