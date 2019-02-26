using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student of the class");
            int student = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter total exams");
            int Exam = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter parts of the exam");
            int PartOfExam = int.Parse(Console.ReadLine());
            
            


            int[, ,] score = new int[student, Exam, PartOfExam];
            int[] total = new int[student];
            for (int i = 0; i < PartOfExam; i++)
            {
                for (int j = 0; j < Exam; j++)
                {
                    Console.WriteLine("Enter student's scroe of exam {0} and part {1}",(j+1),(i+1));
                    for (int k = 0; k < student; k++)
                    {
                        Console.Write("Student {0}: ",(k+1));
                        score[k,j,i]=int.Parse(Console.ReadLine());
                        total[k] = total[k] + score[k, j, i];
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n\n");
            }
            for (int i = 0; i < student; i++)
            {
                Console.WriteLine("Total score of  student {0}: {1}",(i+1),total[i]);   
            }
        }

    }
}
