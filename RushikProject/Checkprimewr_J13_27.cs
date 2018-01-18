using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class Checkprimewr_J13_27
    {
        static void Main(string[] args)
        {
            int a;
            bool x = false;
            System.Console.WriteLine("Enter Integer : ");
            a = int.Parse(Console.ReadLine());
            x = checkprime(a);
            if (x == false)
            {
                Console.WriteLine("Not Prime");
            }
            else {
                Console.WriteLine("Prime");
            }

            
        }
        static bool checkprime(int a)
        {
            
            for (int i = 2; i < (a/2)+1; i++)
            {
                if (a % i == 0)
                {
                    return false;     
                }
            }
            return true;
            
        
        }

    }
}
