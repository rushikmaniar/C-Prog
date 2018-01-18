using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class Marksheet_24
    {
        static void Main(string[] args) {
            int[,] stud = new int[5,7];
            Console.WriteLine("\n\nMarkSheet Of Five Students\n\n");
            
            //Scaning Marks Values
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\n\nEnter Details of Student " + i);
                for (int j = 0; j < 5; j++)
                {
                    //for student number id
                    if (j == 0)
                    {
                        stud[i, j] = i;
                    }
                    //for scnning stud marks
                    else
                    {
                        Console.WriteLine("\nEnter Marks " + j);
                        stud[i, j] = int.Parse(Console.ReadLine());
                        //total marks
                        stud[i, 5] = stud[i, 5] + stud[i, j];
                        //total percentage
                        stud[i, 6] = stud[i, 5] / 4;
                    }

                }
            }


            printarray(stud);




        }

        static void printarray(int[,] stud)
        {
            Console.WriteLine("Rank "+stud.GetUpperBound(1));
            for (int i = 0; i < stud.Rank;i++)
            {
                Console.WriteLine(stud.GetLength(i) + " ");
            }
            
            Console.WriteLine("Student\tMarks1\tMarks2\tMarks3\tMarks4\tTotal\tPercentage");
            //printing 2d array
            
            for (int i = 0; i < 5; i++)
            {
                
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(stud[i,j]+"\t");    
                }
                Console.Write("\n");
            }
             
        }
    }
}
