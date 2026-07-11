using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_35_Read_Write_Property___Just_for_understanding
{

    class A
    {
        private int x;

        public int num
        {
            set
            {
                x = value;
            }
            get
            {
                return x;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A ob = new A();
            ob.num = 100; //set
            Console.WriteLine("Value: {0}", ob.num); //get
            Console.ReadKey();
        }
    }
}
