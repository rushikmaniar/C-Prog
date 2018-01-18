using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class Greater_8
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Enter Two Integer :");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            if(a == b){
                Console.WriteLine("Both Equal");
            }
            if (a > b)
            {
                Console.WriteLine("a =" + a + "is greater than b="+b);
            }
            else {
                Console.WriteLine("b =" + b + "is greater than a="+a);
            }
            
        }
    }
}
