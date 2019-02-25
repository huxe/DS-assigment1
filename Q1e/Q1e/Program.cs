using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q1e
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1,2,3,4,5,6,7,8,9,10,54};
            int Start = 0;
            int End = 11;
            int Mid = (Start + End) / 2;
            int Skey = 54;
            BinarySearch(Start,End,Mid,Skey,arr);
        }

        static void BinarySearch(int START,int END,int MID,int SKEY,int[] ARR)
        {
            while (START<END)
            {
                if (SKEY>ARR[MID])
                {
                    START = MID + 1;
                    MID=(START+END)/2;
                }
                else if (SKEY<ARR[MID])
                {
                    END = MID - 1;
                    MID=(START+END)/2;
                }
                else if (SKEY==ARR[MID])
                {
                    Console.WriteLine("SuccessFull");
                    break;
                }
            }
            if (SKEY!=ARR[MID])
            {
                Console.WriteLine("UnsuccessFull");
            }
        }
    }
}
