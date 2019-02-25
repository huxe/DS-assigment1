using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of an array");
            int la = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Elements of array");
            int[] arr=new int[la];
            for (int i = 0; i < la; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter repeat times");
            int repeat = int.Parse(Console.ReadLine());

            for (int i = 0; i < repeat; i++)
            {
                int temp = arr[0];
                for (int j = 0; j < la-1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[la-1] = temp;
            }
            Console.WriteLine("\n********************\n");
            foreach (var item in arr)
            {
                Console.Write(item+" ");
            }
        }
    }
}
