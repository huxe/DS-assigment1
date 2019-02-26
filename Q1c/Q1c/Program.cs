using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q1c
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter length of array");
            int LA = int.Parse(Console.ReadLine());
            int[] ARR = new int[LA];
            Console.WriteLine("Enter Elements");
            for (int i = 0; i < LA; i++)
            {
                ARR[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Item delete At: ");
            int K = int.Parse(Console.ReadLine());
            Case2(LA,K,ARR);
        }

        public static void Case1(int n, int k, int[] arr)
        {
            n = n - 1;
        }

        public static void Case2(int n, int k, int[] arr)
        {
            int temp= arr[k]; 
            for (int i = 0; i < n-1; i++)
            {
                if (i>=k)
                {
                    arr[i] = arr[i + 1];
                }
            }
            arr[n-1] = temp;
            n = n - 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
