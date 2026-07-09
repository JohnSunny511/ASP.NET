using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_33_Reverse_in_Abstract_class___exam_model
{
    abstract class A
    {
        public abstract void Reverse(int n);
    }
    class Program:A
    {
        public override void Reverse(int n)
        {
            int rem, res = 0;
            while(n > 0)
            {
                rem = n % 10;
                res = res * 10 + rem;
                n /= 10;
            }
            Console.WriteLine(res);
        }
        static void Main(string[] args)
        {
            Program ob = new Program();
            Console.WriteLine("Enter the number to be reversed");
            int n = Convert.ToInt32(Console.ReadLine());
            ob.Reverse(n);
            Console.ReadKey();
        }
    }
}
