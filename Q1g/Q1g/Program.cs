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
            Console.WriteLine("Enter length of array");
            int LA = int.Parse(Console.ReadLine());
            int[] arr = new int[LA];
            Console.WriteLine("Enter Elements");
            for (int i = 0; i < LA; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }            
            foreach (var item in SelectionSort(arr,LA))
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
