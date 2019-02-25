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
            int[] ARR = new int[7] { 1, 5, 4, 6, 3, 0, 0 };
            Console.Write("Enter Number of elements: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Item delete At: ");
            int K = int.Parse(Console.ReadLine());
        }

        public static void Case1(int n, int k, int[] arr)
        {
            n = n - 1;
        }

        public static void Case2(int n, int k, int[] arr)
        {
            int item=arr[k];
        }
    }
}
