using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_50_throw
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x;
                Console.WriteLine("Enter Age");
                x = Convert.ToInt32(Console.ReadLine());
                if (x < 0)
                {
                    throw new Exception("Age cannot be negative");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
            }
            Console.ReadKey();
        }
    }
}
