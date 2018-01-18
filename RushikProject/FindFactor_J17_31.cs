using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class FindFactor_J17_31
    {
        static void Main(string[] args)
        {
            int a, count;
            int[] arr;
            Console.Write("Enter Integer to find factors : ");
            a = int.Parse(Console.ReadLine());
            arr = getFactors(a, out count);
            Console.WriteLine("factors are : ");
            for (int i = 0; i < count; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Console.WriteLine("\n\n");

        }
        static int[] getFactors(int a, out int cnt)
        {
            int[] arr = new int[100];
            arr[0] = 0;
            arr[1] = 1;
            cnt = 2;
            for (int i = 2; i <= a / 2; i++)
            {
                if (a % i == 0)
                {
                    arr[cnt] = i;
                    cnt++;

                }
            }
            return arr;


        }

    }
}
