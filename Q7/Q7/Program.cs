using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array");
            int la = int.Parse(Console.ReadLine());
            int[] arr = new int[la];
            Console.WriteLine("Enter Elements");
            for (int i = 0; i < la; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n***********************\n");
            int[] temp=new int[la];
            
            for (int i = 0,k=la-1, j=0; i < la; i++)
            {
                if (arr[i]%2==0)
                {
                    temp[j] = arr[i];
                    j++;
                }
                else
                {
                    temp[k] = arr[i];
                    k--;
                }
            }

            for (int i = 0; i < la; i++)
            {
                for (int j = 0; j < la - 1; j++)
                {
                    if (temp[j+1]%2==0 && temp[j] > temp[j + 1])
                    {
                        int temp1 = temp[j];
                        temp[j] = temp[j + 1];
                        temp[j + 1] = temp1;
                    }
                    else if (temp[j + 1] % 2 != 0 && temp[j] < temp[j + 1])
                    {
                        int temp1 = temp[j];
                        temp[j] = temp[j + 1];
                        temp[j + 1] = temp1;
                    }
                }
            }

            foreach (var item in temp)
            {
                Console.Write(item+" ");
            }
            
        }
    }
}
