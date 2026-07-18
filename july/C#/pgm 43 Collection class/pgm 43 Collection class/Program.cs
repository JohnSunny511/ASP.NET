using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace pgm_43_Collection_class
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(1002);
            al.Add(200);
            al.Add(300);
            al.Add(400);
            al.Add("Hello");
            Console.WriteLine("Added items");
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);

            }
            foreach (var x in al)
            {
                Console.WriteLine(x);

            }
            Console.ReadKey();
        }
    }
}
