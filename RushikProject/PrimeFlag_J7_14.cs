using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class PrimeFlag_J7_14
    {
        static void Main(string[] args)
        {
            int a;
            int x = 0;
            System.Console.WriteLine("Enter Integer : ");
            a = int.Parse(Console.ReadLine());
            
            for (int i=2;i<=a/2;i++ )
            {
                if(a%i == 0){
                    x = 1;
                    Console.WriteLine("Not Prime");
                    break;
                }
            }
            if(x==0){ 
                Console.WriteLine("It is Prime");
            }
        }

    }
}
