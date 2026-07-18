using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_41_Lambda_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 36, 32, 64, 742, 24, 84, 83, 34, 55 };
            Console.Write("The list :");
            foreach (var value in numbers)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();
            //Using lambda expression to calculate square of each value in the list
            var square = numbers.Select(x => x * x);
            Console.Write("Square: ");
            foreach (var value in square)
            {
                Console.Write("{0} ", value);
            }

            Console.WriteLine();
            var divideby3 = numbers.FindAll(x => (x % 3 == 0));
            Console.Write("Divisible: ");
            foreach (var value in divideby3)
            {
                Console.Write("{0} ", value);

            }

            Console.ReadKey();
        }
    }
}
