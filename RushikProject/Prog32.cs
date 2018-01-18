using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class Prog32
    {
        static void Main(string[] args)
        {
            Console.Write(" \n\n");
            
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 numbers ");
            for(int i=0;i<10;i++){
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write(" Printing 10 numbers ");
            
            ShowArrayInfo(arr);

            Console.Write(" \n\n");
        }
        static void ShowArrayInfo(int[] arr){
            /*for(int i=0;i<10;i++){
                Console.Write(" " + arr[i]);
             }*/
            Console.Write("\n\n");
            Console.WriteLine("Length : "+arr.Count());
            Console.WriteLine("Dimensions : " + arr.Rank);
            Console.WriteLine("LowerBound : " + arr.GetLowerBound(arr.Rank-1));
            Console.WriteLine("UpperBound : " + arr.GetUpperBound(arr.Rank-1));
        
        }
    }
}
