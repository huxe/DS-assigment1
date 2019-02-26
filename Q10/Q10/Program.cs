using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter coulumn of matrix");
            int column = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Rows of matrix");
            int row = int.Parse(Console.ReadLine());
            
            Input_Matrix(row,column);
        }

        static void Input_Matrix(int ROWS,int COLUMN)
        {
            int[,] arr = new int[ROWS, COLUMN];
            Console.WriteLine("Input in Matrix");
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMN; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Transpose_matrix(ROWS,COLUMN,arr);
            display_Matrix(ROWS, COLUMN, arr);
        }

        static void Transpose_matrix(int ROWS, int COLUMN, int[,] ARR)
        {
            Console.WriteLine("\n\nTranspose of Matrix");
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMN; j++)
                {
                    Console.Write(ARR[j,i]+" ");
                }
                Console.WriteLine();
            }
        }

        static void display_Matrix(int ROWS, int COLUMN, int[,] ARR)
        {
            Console.WriteLine("\n\nDisplay of Matrix");
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMN; j++)
                {
                    Console.Write(ARR[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
