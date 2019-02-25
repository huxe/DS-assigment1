using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q1a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array");
            int LA = int.Parse(Console.ReadLine());
            int[] arr=new int[LA];
            Console.WriteLine("Enter Elements");
            for (int i = 0; i < LA; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());   
            }
            foreach (var item in arr)
	        {
	            Console.Write(+item+" ");
            }
            Console.WriteLine();
        }
    }
}
