using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_42_Search_Element_from_Listt
{
    class P
    {
        public static void Main()
        {
            int n, se;
            Console.WriteLine("enter size:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[n];
            List<int> item1 = new List<int>();
            List<int> position = new List<int>();

            Console.WriteLine("enter elements:");

            for (int i = 0; i < n; i++)
            {

                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("search:");

            se = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                if (se == ar[i])
                {
                    item1.Add(ar[i]);
                    position.Add(i);

                }

            }
            for (int i = 0; i < item1.Count; i++)
            {
                Console.WriteLine("The value {0} is at position {1}",item1[i],position[i]+1);
            }
            Console.ReadKey();
        }
    }
}
