using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class Prog36
    {
        static void Main(string[] args)
        {
            Console.Write(" Triangle \n\n");
            Triangle36 t1 = new Triangle36();
            t1.getdata();
            t1.area = t1.getarea();
            //t1.printdata();
            t1.disp();
            Console.Write(" \n\n");
        }
    }
    class TwoDShape36
    {
        protected double height, width;
        public double area=0;

        public void getdata()
        {
            Console.WriteLine("Enter Height and Witdh of Trianle");
            this.height = double.Parse(Console.ReadLine());
            this.width = double.Parse(Console.ReadLine());
        }
        public void printdata()
        {
            Console.WriteLine("Triangle");
            Console.Write("Wtidht: " + width + " Height : " + height + " Area : " + area);
        }


    }

    class Triangle36 : TwoDShape36
    {
        public double getarea()
        {
            double area;
            area = this.height * width * (0.5);
            return (area);
        }
        public void disp()
        {
            Console.WriteLine("Triangle");
            Console.Write("Wtidht: " + width + " Height : " + height + " Area : " + area);
        }


    }
}
