using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q11
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter ROWS of Array 1");
            int RowsM1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter COLUMN of Array 1");
            int ColumnM1 = int.Parse(Console.ReadLine());
            int[,] M1 = new int[RowsM1, ColumnM1];
            Console.WriteLine("Enter Values");
            for (int i = 0; i < RowsM1; i++)
            {
                for (int j = 0; j < ColumnM1; j++)
                {
                    Console.Write("Value of Row:{0} Column:{1} = ",(i+1),(j+1));
                    M1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter ROWS of Array 2");
            int RowsM2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ROWS of Array 2");
            int ColumnM2 = int.Parse(Console.ReadLine());
            int[,] M2 = new int[RowsM2, ColumnM2];

            Console.WriteLine("Enter Values");
            for (int i = 0; i < RowsM1; i++)
            {
                for (int j = 0; j < ColumnM1; j++)
                {
                    Console.Write("Value of Row:{0} Column:{1} = " , (i + 1) , (j + 1));
                    M2[i, j] = int.Parse(Console.ReadLine());
                }
            }


            int[,] ANS = Multipluy(M1,M2,RowsM1,ColumnM1,RowsM2,ColumnM2);
            for (int i = 0; i < RowsM1; i++)
            {
                for (int j = 0; j < ColumnM2; j++)
                {
                    Console.Write(ANS[i,j]+" ");
                }
                Console.WriteLine();
            }
        }

        static int[,] Multipluy(int[,] m1,int[,]m2,int M1R,int M1C,int M2R,int M2C)
        {
            int[,] ans = new int[M1R, M1C];
            for (int i = 0; i < M1R; i++)
            {
                for (int j = 0; j < M2C; j++)
                {
                    for (int k = 0; k < M1R; k++)
                    {
                       ans[i,j] += m1[i, k] * m2[k, j];
                    }
                }
            }
            return ans;
        }
    }
}
