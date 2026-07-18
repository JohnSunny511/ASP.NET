using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace pgm_45_HashTable_and_SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(4, "Red");
            ht.Add(21, "blue");
            ht.Add(5, "green");
            ht.Add(9, "Gold");
            foreach (DictionaryEntry i in ht)
            {
                Console.WriteLine(i.Key + " " + i.Value);

            }

            Console.WriteLine(ht[4]);
            Console.WriteLine("Sorted List");
            SortedList sl = new SortedList();
            sl.Add(21, "blue");
            sl.Add(5, "green");
            sl.Add(9, "Gold");
            foreach (DictionaryEntry i in sl)
            {
                Console.WriteLine(i.Key + " " + i.Value);

            }
            Console.ReadKey();
        }
    }
}
