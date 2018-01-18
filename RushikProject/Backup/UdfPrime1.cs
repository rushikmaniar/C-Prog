using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class UdfPrime1
    {
        static void Main(string[] args)
        {
            int a;
            
            System.Console.WriteLine("Enter Integer : ");
            a = int.Parse(Console.ReadLine());
            checkprime(a);
            


        }
        static void checkprime(int a)
        {
            int x = 0;

            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    x = 1;
                    break;

                }
            }
            if (x == 1)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                Console.WriteLine("Prime");
            }
           }

    }
}
