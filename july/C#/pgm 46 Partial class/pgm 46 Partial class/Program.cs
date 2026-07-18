using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_46_Partial_class
{
    partial class Emp
    {
        public string name { set; get; }

        public int age { set; get; }

    }

    partial class Emp
    {
        public string address { set; get; }
        public string salary { set; get; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Emp ob = new Emp();
            ob.name = "John";
            ob.age = 23;
            ob.address = "Vellikulangara";
            ob.salary = "12LPA";
            Console.WriteLine($"\nName:{ob.name}\nAge:{ob.age}\nAddress:{ob.address}\nSalary:{ob.salary}");
            Console.ReadKey();

        }
    }
}
