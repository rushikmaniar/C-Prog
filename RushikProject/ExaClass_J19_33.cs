using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class ExaClass_J19_33
    {
        public static void Main(string[] args)
        {
            Number n1 = new Number();
            n1.set("Rushik",18,56,56);
            n1.disp();
        }
    }
    class Number
    {
        int marks1, marks2;
        public string name;
        public int age;

        public void set(string name, int age, int marks1, int marks2)
        {
            this.name = name;
            this.age = age;
            this.marks1 = marks1;
            this.marks2 = marks2;
        }
        public void disp()
        {
            Console.WriteLine("Person details :");
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Age :" + age);
            Console.WriteLine("marks1 :" + marks1);
            Console.WriteLine("marks2 :" + marks2);
        }
    }
}
