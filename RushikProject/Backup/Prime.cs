using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class Prime
    {
        static void Main(string[] args)
        {
            int a,i=0;
            System.Console.WriteLine("Enter Integer : ");
            a = int.Parse(Console.ReadLine());

            for (i = 2; i < a/2; i++)
            {
                if (a % i == 0)
                {
                    Console.WriteLine("Not Prime");
                    break;
                }
            }
            if(i == a-1)
            Console.WriteLine("It is Prime");
               
           
        }

    }
}
