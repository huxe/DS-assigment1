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
            int[] arr = { 1,2,3,5,6};
            Console.WriteLine(LinearSearch(arr,5,3));

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
