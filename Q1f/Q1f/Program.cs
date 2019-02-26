using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q1f
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array");
            int la = int.Parse(Console.ReadLine());
            int[] arr = new int[la];
            Console.WriteLine("Enter Elements");
            for (int i = 0; i < la; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            
            foreach (var item in BubbleSort(la,arr))
            {
                Console.Write(item+" ");    
            }
        }

        static int[] BubbleSort(int LA,int[] ARR)
        {
            for (int i = 0; i < LA; i++)
            {
                for (int j = 0; j < LA-1; j++)
                {
                    if (ARR[j]>ARR[j+1])
                    {
                        int temp=ARR[j];
                        ARR[j] = ARR[j + 1];
                        ARR[j + 1] = temp;
                    }
                }   
            }
            return ARR;
        }
    }
}
