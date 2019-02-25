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
            int[] arr ={ 2, 5, 1, 0, 4, 7, 9, 3, -2, 10, 20, 15};
            int[] temp=new int[12];
            int la = 12;
            for (int i = 0,k=11, j=0; i < la; i++)
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
