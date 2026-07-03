using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_15_Matrix_Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            int r1, c1,r2,c2, i, j;
            Console.WriteLine("Enter the row and column of Matrix 1");
            r1 = Convert.ToInt32(Console.ReadLine());
            c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the row and column of Matrix 2");
            r2 = Convert.ToInt32(Console.ReadLine());
            c2 = Convert.ToInt32(Console.ReadLine());
            int[,] ar1 = new int[r1, c1];
            int[,] ar2 = new int[r2, c2];
            int[,] ar3 = new int[r1, c1];
            if(r1 == r2 && c1 == c2){
                Console.WriteLine("Enter the elements to Matrix 1");
                for(i = 0; i < r1; i++)
                {
                    for (j = 0; j < c1; j++)
                    {
                        ar1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.WriteLine("Enter the elements to Matrix 2");
                for (i = 0; i < r2; i++)
                {
                    for (j = 0; j < c2; j++)
                    {
                        ar2[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine("Multiplied Matrix:");
                for (i = 0; i < r2; i++)
                {
                    for (j = 0; j < c2; j++)
                    {
                        ar3[i, j] = ar1[i, j] + ar2[i, j];
                        Console.Write(ar3[i, j]+ " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Addition Not Possible");
            }
            Console.ReadKey();
        }
    }
}
