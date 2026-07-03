using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm_14_2D_Matrix
{
    class Program
    {
        static void Main(string[] args)
        { 
            int row, col, i, j;
            Console.WriteLine("Enter the row Limit");
            row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the column limit");
            col = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[row,col];
            Console.WriteLine("Enter the numbers");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The 2D array:");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
