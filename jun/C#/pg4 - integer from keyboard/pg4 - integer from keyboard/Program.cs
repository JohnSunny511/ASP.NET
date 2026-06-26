using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg4___integer_from_keyboard
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a Number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Entered Numer : {n}");
            Console.ReadKey();
        }
    }
}
