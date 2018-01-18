using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class Primerange_J8_8
    {
        static void Main(string[] args)
        {
            int from, to , x=0;
            System.Console.WriteLine("Enter Range for getting prime numbers : ");
            from = int.Parse(Console.ReadLine());
            to = int.Parse(Console.ReadLine());
          
            
            if (to <= from)
            {
                Console.Write("To Should be greater than from");
            }
            else
            {
               for (int i = from; i <=to; i++)
                {

                    int t = Math.Abs(i);

                        for (int j = 2; j < (t/2) ; j++)
                        {
                            if (i % j == 0)
                            {
                                x = 1;
                            }
                        }
                        if (x == 0)
                        {
                            Console.Write(" " + i);
                        }
                        x = 0;
                    
               
                }

                Console.Write(" \n\n");
            }
           
        }
    }
    
}
