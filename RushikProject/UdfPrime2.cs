using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class UdfPrime2
    {
        static void Main(string[] args)
        {
            int a;
            int x = 0;
            System.Console.WriteLine("Enter Integer : ");
            a = int.Parse(Console.ReadLine());
            x = checkprime(a);
            if (x == 1)
            {
                Console.WriteLine("Not Prime");
            }
            else {
                Console.WriteLine("Prime");
            }

            
        }
        static int checkprime(int a)
        {
            
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    return 1;
                    
                }
            }
            return 0;
            
        
        }

    }
}
