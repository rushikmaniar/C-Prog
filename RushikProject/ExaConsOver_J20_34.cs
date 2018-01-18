using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class ExaConsOver_J20_34
    {
        public static void Main(string[] args)
        {
            Person_34 p1 = new Person_34();
            p1.disp();
            Person_34 p2 = new Person_34("Meet",15);
            p2.disp();
        }

    }
    class Person_34
    {
        string name;
        int age;
        public Person_34()
        {
            Console.WriteLine("Default Construtor");
            name = "Rushik";
            age = 18;
        }
        public Person_34(string name, int age)
        {
            Console.WriteLine("Argument Construtor");
            this.name = name;
            this.age = age;
        }
        public void disp()
        {
            Console.WriteLine("Person Details :");
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Age :" + age);
        }

    }

}
