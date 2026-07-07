using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_19_Reference_Parameter___Pass_by_address_
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Program ob = new Program();
            ob.check(ref x);
            Console.WriteLine("Value of x inside Main Function : {0}", x);  //since we passed the memory address of x to check function  the value of x here changes as  per changes made there
            Console.ReadKey();
        }

        public void check(ref int x)      //here x is a same varaible, since we passed the memory location of that variable of x to this function 
        {
            x = x + 10;
            Console.WriteLine("Value of x inisde the function : {0}", x);
        }
    }
}
