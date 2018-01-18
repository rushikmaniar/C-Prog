using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class CallByVal_J14_28
    {
        static void Main(string[] args)
        {
            int a,b;

            Console.WriteLine("Enter Two Integer : ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            swap(a,b);
            Console.WriteLine("But Original value does not change");
            Console.WriteLine("After Swap a=" + a + " b=" + b);


        }
        static void swap(int a,int b)
        {
            int temp;

            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After Swap a="+a+" b="+b);
        }
    }
}

        
