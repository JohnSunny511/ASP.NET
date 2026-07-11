using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_36_Automatic_Property
{

    class A
    {
        public int num
        {
            set;
            get;
        }
    }
    class B
    {
        static void Main(string[] args)
        {
            A ob = new A();
            ob.num = 100; //set
            Console.WriteLine("Value of X : {0}", ob.num);
            Console.ReadKey();
        }
    }
}
