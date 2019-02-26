using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q1h
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
            for (int i = 0; i < LA - 1; i++)
            {
                int j = i + 1;
                if (ARR[i]>ARR[i+1])
                {
                    while (j > 0)
                    {
                        if (ARR[j - 1] > ARR[j])
                        {
                            int temp = ARR[j - 1];
                            ARR[j - 1] = ARR[j];
                            ARR[j] = temp;

                        }
                        j--;
                    }

                }
            }
            return ARR;
        }
    }
}
