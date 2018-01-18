using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class CallByReferenceSwap
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Enter Two Integer : ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            swap(ref a, ref b);
            Console.WriteLine("And Original value Also change");
            Console.WriteLine("After Swap a=" + a + " b=" + b);


        }
        static void swap(ref int a, ref int b)
        {
            int temp;

            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After Swap a=" + a + " b=" + b);
        }
    }
}


