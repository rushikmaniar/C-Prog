using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class GreaterThree
    {
        static void Main(string[] args)
        {
            int a, b,c;
            Console.Write("Enter Three Integer :");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("A is Greatest");
            }
            else if (b > c && b > a)
            {
                Console.WriteLine("B is Greatest");
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("C is Greatest");
            }
            else if (a == b && a > c)
            {
                Console.WriteLine("A and B are Greater Than C");
            }
            else if (b == c && b > a)
            {
                Console.WriteLine("B and C are Greater Than A");
            }
            else if (c == a && a > b)
            {
                Console.WriteLine("C and A are Greater Than B");
            }
            else if (a == b &&  b == c)
            {
                Console.WriteLine("All Are Equal");
            }

        }
    }
}
