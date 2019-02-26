using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q12
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter Sqare matrix length");
            int M1 = int.Parse(Console.ReadLine());
            int[,] arr = new int[M1, M1];
            Console.WriteLine("Enter Values");
            for (int i = 0; i < M1; i++)
            {
                for (int j = 0; j < M1; j++)
                {
                    Console.Write("Value of Row:{0} Column:{1} = ", (i + 1), (j + 1));
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }


            DignalDifference(arr,M1);
        }

        static void DignalDifference(int[,] ARR,int m1)
        {
            int D1 = 0,D2=0;
            for (int i = 0; i < m1; i++)
            {
                D1 += ARR[i, i];
            }
            Console.WriteLine("The left-to-right diagonal "+D1);
            for (int i=0,j=m1-1; j >= 0; j--)
            {
                D2 += ARR[i, j];
                i++;
            }
            Console.WriteLine("The right-to-left diagonal " + D2);
            Console.WriteLine("Their absolute difference is "+D1+"-"+D2+"= "+(D1-D2));
        }
    }
}
