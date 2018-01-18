using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class Prog35
    {
        static void Main(string[] args)
        {
            Console.Write(" Triangle \n\n");
            Triangle t1 = new Triangle();
            t1.getdata();
            t1.area = t1.getarea();
            t1.printdata();
            Console.Write(" \n\n");
        }
    }
    class TwoDShape {
        protected double height, width;
        public double area;

        public void getdata() 
        {
            Console.WriteLine("Enter Height and Witdh of Trianle");
            this.height = double.Parse(Console.ReadLine());
            this.width = double.Parse(Console.ReadLine());
        }
        public void printdata()
        {
            Console.WriteLine("Triangle");
            Console.Write("Wtidht: "+width + " Height : "+ height + " Area : "+area);
        }
    
    
    }

    class Triangle : TwoDShape {
        public double getarea()
        {
            double area;
            area = this.height * width * (0.5);
            return (area);
        }
    
    
    }
}
