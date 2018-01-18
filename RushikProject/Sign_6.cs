using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class Sign_6
    {
        static void Main(string[] args)
        {
            int a;
            System.Console.Write("Enter Integer : ");
            a = int.Parse(Console.ReadLine());

            if (a <= 0)
            {
                if (a == 0)
                {
                    Console.WriteLine("Zero");
                }
                else {
                    Console.WriteLine("Negative");
                }
            }
            else
            {
                Console.WriteLine("Positive");
            }
        }

    }
}
