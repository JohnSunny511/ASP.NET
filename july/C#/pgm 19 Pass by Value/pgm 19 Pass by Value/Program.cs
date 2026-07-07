using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_19_Pass_by_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Program ob = new Program();
            ob.check(x);
            Console.WriteLine("Value of x inside Main Function : {0}",x);  //since we had differnt varaible in check function even though same alpahanet the value of x here remains same
            Console.ReadKey();
        }

        public void check(int x)      //here x is a differnt varaible, since it is a differnt function and we passed a value to this function 
        {
            x = x + 10;
            Console.WriteLine("Value of x inisde the function : {0}", x);
        }
    }
}
