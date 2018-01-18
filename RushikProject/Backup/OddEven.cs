using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class OddEven
    {
        static void Main(string[] args)
        {
            int a;
            System.Console.WriteLine("Enter Integer : ");
            a = int.Parse(Console.ReadLine());

            
            if (a % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else {
                Console.WriteLine("Odd");
            }
        }
 
    }
}
