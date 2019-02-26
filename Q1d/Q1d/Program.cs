using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q1d
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
            Console.WriteLine("Enter SearchKey");
            int sKey = int.Parse(Console.ReadLine());

            Console.WriteLine(LinearSearch(arr, LA, sKey));


        }
        static string LinearSearch(int[] ARR,int N,int ITEM)
        {
            for (int i = 0; i < N-1; i++)
            {
                if (ARR[i]==ITEM)
                {
                    return"Success Full";
                }   
            }
            return "Success Full";
        }

    }
}
