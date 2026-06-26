using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg_7_Swap_without_3rd_varibale
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2;
            Console.WriteLine("Enter the first Number");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Before Swapping: n1 = {n1}, n2 = {n2}");
            n1 = n1 + n2;
            n2 = n1 - n2;
            n1 = n1 - n2;
            Console.WriteLine($"After Swapping: n1 = {n1}, n2 = {n2}");
            Console.ReadKey();
        }
    }
}
