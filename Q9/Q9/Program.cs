using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] query = { "ab","bc","abc" };
            string[] strings = { "ab", "ab", "bc" };
            foreach (var item in MatchingIntegers(query, strings))
            {
                Console.Write(item + " ");
            }
        }

        static int[] MatchingIntegers(string[] QUERY, string[] STRINGS)
        {
            int[] Result = new int[3];
            for (int i = 0; i < 3; i++)
            {
                int count = 0;
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
