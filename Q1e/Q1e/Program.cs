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
            Console.WriteLine("Enter length of array");
            int LA = int.Parse(Console.ReadLine());
            int[] arr = new int[LA];
            Console.WriteLine("Enter Elements");
            for (int i = 0; i < LA; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter search key");
            int Skey =int.Parse(Console.ReadLine());
            int Start = 0;
            int End = LA;
            int Mid = (Start + End) / 2;
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
