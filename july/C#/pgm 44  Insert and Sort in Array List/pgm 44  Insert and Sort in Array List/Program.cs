using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace pgm_44__Insert_and_Sort_in_Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(100);
            al.Add(200);
            al.Add(550);
            al.Add(700);
            al.Insert(1, 500);
            Console.WriteLine("Inserted Items");
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);

            }
            al.Sort();
            Console.WriteLine("Sorted items");
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }

            al.Remove(200);
            Console.WriteLine("Remove items");
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }

            al.RemoveAt(2);
            Console.WriteLine("RemoveAt items");
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }

            Console.ReadKey();
        }
    }
}
