using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class JaggedArray
    {
        static void Main(string[] args)
        {
            Console.Write(" \n\n");
            int n=0;
            int[][] arr = new int[3][];
            arr[0] = new int[1];
            arr[1] = new int[5];
            arr[2] = new int[5];
            
            Console.WriteLine("Our Array is like this");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(" " + j);
                    n++;
                }
                Console.Write("\n");
                
            }

          
            Console.WriteLine("Enter " + 
                n + " numbers ");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = int.Parse(Console.ReadLine());
                }
                
            }
           
            Console.WriteLine(" Printing "+ n + " numbers ");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(" " + arr[i][j]);
                }
                Console.Write("\n");
            }

           /* foreach (int[] i in arr)
            {
                foreach (int j in i)
                {
                    Console.WriteLine(j);
                }
            }*/

            Console.Write(" \n\n");
        }

    }
}
