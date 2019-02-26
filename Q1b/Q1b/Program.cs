using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q1b
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter length of array");
            int N = int.Parse(Console.ReadLine());
            int[] ARR = new int[N+1];
            Console.WriteLine("Enter Elements");
            for (int i = 0; i < N-1; i++)
            {
                ARR[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Item place At: ");
            int K = int.Parse(Console.ReadLine());
            Console.Write("Item you wanna place: ");
            int ITEM = int.Parse(Console.ReadLine());

        }
        public static void Case1(int n,int item,int[] arr)
        {
            arr[n] = item;
        }
        public static void Case2( int n, int k, int item, int[] arr)
        {
            for (int j = n - 1; j >= k; j--)
            {
                arr[j + 1] = arr[j];
            }
            arr[k]=item;
            
        }
    }
}
