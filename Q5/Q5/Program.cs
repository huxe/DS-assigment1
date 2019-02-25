using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {68,37,25,22,17,15,11,9,5,3 };
            int la = 9;
            int skey = 17;
            BinarrySearch(arr,la,skey);
        }
        static void BinarrySearch(int[] ARR,int LA,int SKEY)
        {
            bool check = true;
            int start = 0;
                int end = LA;
            while (start<=end)
            {
                int mid = (start + end) / 2;

                if (SKEY==ARR[mid])
                {
                    check = false;
                    Console.WriteLine("Successfull");
                    break;
                }
                else if (SKEY>ARR[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
                
            }
            if (check==true)
            {
                Console.WriteLine("Unsuccessfull");

            }
            
        }
    }
}
