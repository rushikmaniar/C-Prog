using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class SelSort_21
    {
        static void Main(string[] args)
        {
            Console.Write(" \n\n");

            int[] arr = new int[10];
            Console.Write("Enter 10 numbers ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write(" Printing 10 numbers ");
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if(arr[i] > arr[j]){
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Console.Write(" \n\n");
        }

    }
}
