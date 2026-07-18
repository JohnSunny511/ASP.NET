using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_49_Exception_and_Finally
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x, y;
                Console.WriteLine("Enter 2 numbser");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Output : {x / y}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally Block");
            }
            Console.ReadKey();
        }
    }
}
