using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_37_Sum_of_2_Numbers_using_Automatic_property
{
    class A
    {
        public int num1
        {
            set;
            get;
        }

        public int num2
        {
            set;
            get;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A ob = new A();
            Console.WriteLine("Enter two Numbers to Add");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            ob.num1 = n1;
            ob.num2 = n2;
            Console.WriteLine($"Sum : {ob.num1 + ob.num2}");
            Console.ReadKey();
        }
    }
}
