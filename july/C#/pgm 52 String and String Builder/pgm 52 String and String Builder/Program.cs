using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_52_String_and_String_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //String(immutable) and StringBuilder(mutable)
            String a = "Good Mornin";
            String b = "Hello Friend";
            String c = a.Clone().ToString();
            Console.WriteLine(c);
            Console.WriteLine(a.CompareTo(b));
            Console.WriteLine(a.CompareTo(a));
            Console.WriteLine(a.Equals(a));
            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.StartsWith("G"));
            Console.WriteLine(a.StartsWith("d"));
            Console.WriteLine(b.GetType());
            Console.WriteLine(a.IndexOf("o"));
            Console.WriteLine(a.LastIndexOf("o"));
            Console.WriteLine(b.ToUpper());
            Console.WriteLine(b.ToLower());

            String s = " Hello Friend ";
            Console.WriteLine(s.Trim());

            String a1 = "Good Morning";
            string x1 = a1.Insert(0, "Hai, ");
            Console.WriteLine(x1);

            String b1 = "Hello Friend";
            Console.WriteLine(b1.Remove(7));

            Console.WriteLine(a1.Substring(2, 5));




            String d = "hai how are you";
            char[] ar = new char[15];
            d.CopyTo(0, ar, 0, 6);
            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write(ar[i]);
            }


            String si = "ggg";
            StringBuilder sb = new StringBuilder("haii");
            sb.Append("hello");
            sb.AppendLine();
            sb.Append("Welcome to our program");
            Console.WriteLine(sb);


            Console.ReadKey();

        }
    }
}
