using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q13
{
    class Program
    {
        static void Main(string[] args)
        {
            int i ;
            
            int[] avg =new int[3];
            int min = avg[0], max = avg[0];
            
            Console.WriteLine("Enter Values\n\n");

            int[,] arr = new int[3, 7];

            for (i = 0; i < 3; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write("Value of Monkey:{0} Day:{1} = ", (i + 1), (j + 1));
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (i = 0; i < 3; i++)
            {
                for (int j = 0; j < 7; j++)
			    {
                    avg[i] = avg[i] + arr[i, j];
			    }
                Console.WriteLine("Average Food of monkey "+(i+1)+": " + (avg[i]/7));

                if (min>avg[i]||i==0)
                {
                    min = avg[i];
                }
                if (max<avg[i])
                {
		             max=avg[i];
                }
            }
            Console.WriteLine("Min food per day: "+min);
            Console.WriteLine("Max food per day: " + max);
        }
    }
}
