using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class Arith_J1_3
    {
        static void Main(string[] args)
        {
            int a, b, c;
            System.Console.WriteLine("Enter Two integer");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            //Addition
            c = a + b;
            Console.WriteLine("Addition : " + c);

            //Subtraction
            c = a - b;
            Console.WriteLine("Subtraction : " + c);

            //Multiplication
            c = a * b;
            Console.WriteLine("Multiplication : " + c);
            if (b == 0)
            {
                Console.WriteLine("Division not possible");
                Console.WriteLine("Modules not possible");
            }
            else
            {
                //division
                c = a / b;
                Console.WriteLine("Division : " + c);

                //Modules
                c = a % b;
                Console.WriteLine("Modules : " + c);
            }
       }
           
    }
}
