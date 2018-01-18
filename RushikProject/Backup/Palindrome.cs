using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            int a, sum = 0, r = 0;
            Console.Write("Enter Integer :");
            a = int.Parse(Console.ReadLine());
            int i = a;
            while (i != 0)
            {
                //Console.Write("\n\t " +i+" \t " + r + " \t " + sum + " \t ");
                r = i % 10;
                sum = sum*10 + r;
                i = i / 10;
                //Console.Write("new sum = " + sum);
            }
        
            //Console.WriteLine(sum);
            if (a == sum)
            {
                Console.WriteLine("Palindrome");
            }
            else {
                Console.WriteLine("not Palindrome");
            }

        }
    }
}
