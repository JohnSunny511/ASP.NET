using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_17_function_calling
{
    class Program
    {
        static void Main(string[] args)
        {
            Program o = new Program();

            o.display();   // void function can be called by just creating a object of that class and use that to call the function

            sfun();    //A static function can be called without creating an object
             
            int s = o.sum();         //An int Function can be called by assigning it to same data type variable
            Console.WriteLine($"Sum: {s}");

            o.product();   //When there is no return type just give all the instructions in the function itself

            Console.ReadKey();
        }

        public void display()
        {
            Console.WriteLine("Sample");
        }
       
        public static void sfun()
        {
            Console.WriteLine("Static Function");
        }

        public int sum()
        {
            int x = 20, y = 30;
            int s = x + y;
            return s;
        }

        public void product()
        {
            int x = 20, y = 30;
            int p = x * y;
            Console.WriteLine($"{x} x {y} = {p}");
        }
    }
}
