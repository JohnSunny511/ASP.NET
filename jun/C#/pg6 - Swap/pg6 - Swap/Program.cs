using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg6___Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp,n1 = 10,n2 = 20;
            Console.WriteLine($"Before Swapping : n1 = {n1}, n2 = {n2}");
            temp = n1;
            n1 = n2;
            n2 = temp;
            Console.WriteLine($"Swapped Values : n1 = {n1}, n2 = {n2}");
            Console.ReadKey();
        }
    }
}
