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
            int[] ARR=new int[7] {1,5,4,6,3,0,0};
            Console.Write("Enter Number of elements");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Item place At: ");
            int K = int.Parse(Console.ReadLine());
            Console.Write("Item you wanna place: ");
            int ITEM = int.Parse(Console.ReadLine());

        }
        public static void Case1(int n,int k,int item,int[] arr)
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
