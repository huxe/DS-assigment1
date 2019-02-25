using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q1g
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr={1,5,4,9,8};
            int la = 5;
            
            foreach (var item in SelectionSort(arr,la))
            {
                Console.Write(item+" ");
            }
        }

        static int[] SelectionSort(int[] ARR,int LA)
        {
            for (int i = 0; i < LA-2; i++)
            {
                int min = i;
                for (int j = i+1; j < LA-1; j++)
                {
                    if (ARR[min]>ARR[j])
                    {
                        min = j;
                    }
                }
                int temp = ARR[i];
                ARR[i] = ARR[min];
                ARR[min] = temp;

            }
            return ARR;
        }
    }
}
