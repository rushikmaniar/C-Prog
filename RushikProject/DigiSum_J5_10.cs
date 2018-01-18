using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class DigiSum_J5_10
    {
        static void Main(string[] args)
        {
            int a,sum=0,r=0;
            Console.Write("Enter Integer :");
            a = int.Parse(Console.ReadLine());
            int i=Math.Abs(a);
            while(i != 0){
                //Console.Write("\n\t " +i+" \t " + r + " \t " + sum + " \t ");
                r = i % 10;
                sum = sum + r;
                i = i / 10;
                //Console.Write("new sum = " + sum);
            }
            Console.WriteLine("Sum is :"+sum);
        }
    }
}
