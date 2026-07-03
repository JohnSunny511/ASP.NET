using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_16_Matrix_Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int r1, c1, r2, c2, i, j, k;
            Console.WriteLine("Enter the Row and Colum Limit of Matrix 1");
            r1 = Convert.ToInt32(Console.ReadLine());
            c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Row and Column Limit of Matrix 2");
            r2 = Convert.ToInt32(Console.ReadLine());
            c2 = Convert.ToInt32(Console.ReadLine());
            int[,] ar1 = new int[r1, c1];
            int[,] ar2 = new int[r2, c2];
            int[,] ar3 = new int[r2, c2];
            if (r1 == c2)
            {
                Console.WriteLine("Enter the First Matrix");
                for (i = 0; i < r1; i++)
                {
                    for (j = 0; j < c1; j++)
                    {
                        ar1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.WriteLine("Enter the second Matrix");
                for (i = 0; i < r2; i++)
                {
                    for (j = 0; j < c2; j++)
                    {
                        ar2[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine("Resultant Matrix:");
                for (i = 0; i < r1; i++)
                {
                    for (j = 0; j < c2; j++)
                    {
                        for (k = 0; k < r2; k++)
                        {
                            ar3[i, j] += ar1[i, k] * ar2[k, j];
                        }
                        Console.Write(ar3[i, j] + " ");

                    }
                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine("Cannot Multiply");
            }
            Console.ReadKey();
        }
    }
}
