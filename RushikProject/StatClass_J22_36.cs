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
            System.Console.Write("Enter Integer : ");
            a = int.Parse(Console.ReadLine());
            //MyNumber.sign(a);
            //MyNumber.checkPrime(a);
            sum=MyNumber.Reverse(a);
            Console.WriteLine("Reverse = "+sum);

            
        }

    }
    static class MyNumber {

        public static void sign(int a) {
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
                }
            }
            if (x == 0)
            {
                Console.WriteLine("It is Prime");
            }

        }

        public static double Reverse(int a)
        {
            int i, r;
            double sum = 0;
            int digit = 0;
            i = a;
            while (i != 0)
            {
                //r = i % 10;
                digit++;
                i = i / 10;

            }
             //Console.WriteLine(digit);
            
            i = a;
            int j = digit;
            while (j != 0)
            {

                r = i % 10;
                double temp = r * Math.Pow(10, j - 1);
                sum = sum + temp;
                i = i / 10;
                j--;
            }
            
            return sum;

        }


    
    }
}
