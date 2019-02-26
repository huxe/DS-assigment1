using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q8
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] query = { 1,2,3};
            int[] strings = { 1, 1, 2 };
            foreach (var item in MatchingIntegers(query,strings))
            {
                Console.Write(item+" ");   
            }
        }

        static int[] MatchingIntegers(int[] QUERY,int[] STRINGS)
        {
            int[] Result=new int[3];
            for (int i = 0; i < 3; i++)
            {
                int count=0;
                for (int j = 0; j < 3; j++)
                {
                    if (STRINGS[j] == QUERY[i])
                    {
                        count++;
                    }
                }
                Result[i] = count;
            }
            return Result;
        }
    }
}
