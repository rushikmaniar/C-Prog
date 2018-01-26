using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class StatClass_J22_36
    {
        static void Main(string[] args)
        {
            int a;
            double sum;
            Console.Write("Enter Integer : ");
            a = int.Parse(Console.ReadLine());
            MyNumber.sign(a);
            MyNumber.checkPrime(a);
            sum = MyNumber.Reverse(a);
            Console.WriteLine("Reverse = " + sum);


        }

    }
    static class MyNumber
    {

        public static void sign(int a)
        {
            if (a <= 0)
            {
                if (a == 0)
                {
                    Console.WriteLine("Zero");
                }
                else
                {
                    Console.WriteLine("Negative");
                }
            }
            else
            {
                Console.WriteLine("Positive");
            }

        }

        public static void checkPrime(int a)
        {
            int x = 0;
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    x = 1;
                    Console.WriteLine("Not Prime");
                    break;
                }
            }
            if (x == 0)
            {
                Console.WriteLine("It is Prime");
            }
            return;

        }

        public static double Reverse(int a)
        {
            int i, r;
            double sum = 0;

            i = a;

            while (i != 0)
            {

                r = i % 10;
                sum = (sum * 10) + r;
                i = i / 10;

            }

            return sum;

        }



    }
}
