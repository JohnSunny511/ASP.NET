using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_23_Output_Parameter
{
    class Program
    {
        //Out parameter is used to send more than one variable from a function because normally only one variable is allowed, the variable with out dont need to be returned or initialized
        static void Main(string[] args)
        {
            Program ob = new Program();
            int a = 10, b, c;                   //b is not initialized, it is just declared
            c = ob.display(a, out b);
            Console.WriteLine("a = {0}, b = {1}", c, b);        ///The updated value of b is there without returning it since it was done using out parameter
            Console.ReadKey();
        }

        public int display(int a,out int b)
        {
            a += 20;
            b = a + 30;
            return a;             // b is not returned
        } 
    }
}
