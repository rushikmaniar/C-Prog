using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class Branching
    {
        static void Main(string[] args)
        {
            Myclass myobj = new Myclass();
            int a,b,s;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            s = myobj.getsum(a,b);
            Console.WriteLine("Your number : "+s);
           
            
        }
    }
    class Myclass {
        public int getsum(int a,int b) {
            int s = a + b;
            return s;
        }
    }
}
