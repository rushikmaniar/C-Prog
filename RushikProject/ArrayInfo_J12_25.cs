using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class ArrayInfo_J12_25
    {
        static void Main(string[] args)
        {
            Console.Write(" \n\n");
            
            int[,] arr = new int[10,5];
            //Console.WriteLine("Enter 10 numbers ");
            /*for(int i=0;i<10;i++){
                arr[i] = int.Parse(Console.ReadLine());
            }*/
            Console.Write(" Printing Array info");
            
            ShowArrayInfo(arr);

            Console.Write(" \n\n");
        }
        static void ShowArrayInfo(Array arr){
            /*for(int i=0;i<10;i++){
                Console.Write(" " + arr[i]);
             }*/
            Console.Write("\n\n");

            
            
            if (arr.Rank == 1)
            {
                Console.WriteLine("Length : " + arr.Length);
            }
            else {
                Console.WriteLine("Dimensions : " + arr.Rank);
                Console.WriteLine("Length : " + arr.Length);
                for(int i = 0; i < arr.Rank ; i++){
                    Console.WriteLine("\n\n");
                    Console.WriteLine("For Dimensions : " + i);
                    Console.WriteLine("Length : " + arr.GetLength(i));
                    Console.WriteLine("UpperBound : " + arr.GetUpperBound(i));
                    //Console.WriteLine("LowerBound : " + arr.GetLowerBound(i));
                }
            }
        }
    }
}
