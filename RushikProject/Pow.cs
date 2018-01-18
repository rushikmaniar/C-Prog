using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class Pow
    {
        static void Main(string[] args)
        {
            double a;
            Console.Write("Enter Integer :");
            a = int.Parse(Console.ReadLine());
            double i = 0, j = 2, flag = 0;
            while (i <= a)
            {
                i = Math.Pow(2,j);
                //i = i * 2;
                if (i == a)
                {
                    flag = 1;
                    break;
                }
                j++;
            }
            if (flag == 1)
            {
                Console.WriteLine("Power Of 2");
            }
            else {
                Console.WriteLine("Not Power Of 2");
            }
        }
    }
}
