﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class Prog37
    {
        static void Main(string[] args)
        {
            Console.Write(" Triangle \n\n");
            Triangle37 t1 = new Triangle37();
            t1.getdata();
            t1.area = t1.getarea();
            //t1.printdata();
            t1.disp();
            Console.Write(" \n\n");
        }
    }
    class TwoDShape37
    {
        double height, width;
        public double area = 0;

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
        public double getheight()
        {
            return height;
        }
        public double getwidth()
        {
            return width;
        }

    }

    class Triangle37 : TwoDShape37
    {

        double width, height;
        public Triangle37() {

            height = getheight();
            width = getwidth();
        
        }
        public double getarea()
        {
            double area;
            area = height * width * (0.5);
            return (area);
        }
        public void disp()
        {
            Console.WriteLine("Triangle");
            Console.Write("Wtidht: " + width + " Height : " + height + " Area : " + area);
        }


    }
}
