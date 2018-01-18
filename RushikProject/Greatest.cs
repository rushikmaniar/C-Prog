using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class Greatest
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Enter Three Integer :");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("A is Greatest");
                    Console.WriteLine("s1");
                }
                /*else if (a == c)
                {
                    Console.WriteLine(" A and C is Greatest");
                }*/
                else
                {
                    Console.WriteLine(" C is Greatest");
                }
            }
            else
            {
                if (b > c)
                {   
                      Console.WriteLine("B is Greatest");
                }
                else {
                    Console.WriteLine("C is Greatest");
                }
                    /*else if (b == a)
                    {
                        Console.WriteLine(" B and A is Greatest");
                    }*/

                
            }
            /*if (c > a)
            {
                if (c > b)
                {
                    Console.WriteLine("C is Greatest");
                }
                /*else if (c == b)
                {
                    Console.WriteLine(" C and B is Greatest");
                }*/
               
            //}
           /* else
            {
                Console.WriteLine("All are Equal");
            }*/


        }
    }
}
