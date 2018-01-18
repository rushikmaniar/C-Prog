using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class Person1
    {
        static void Main(string[] args) {
            Person[] p1 = new Person[3];
            
            int count;
            for(int i=0;i<3;i++){
                p1[i] = new Person(); 
                Console.WriteLine("Person"+i);
                p1[i].getDetails();
                Console.WriteLine("\n\n");
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Person" + i);
                p1[i].PrintDetails();
                Console.WriteLine("\n\n");
            }
            //p1.getDetails();
            
            count = p1[0].getPersons();
            Console.WriteLine("No Of Persons :"+count);
        
        }
    }
    class Person {
            String name;
            int age;
            public static int count;
    public Person() {
        count++;
    }
    public int getPersons(){
        return count;
    }
    public void getDetails()
    {
        Console.Write("Enter Name :");
        name = Console.ReadLine();
        Console.Write("Enter Age :");
        age = int.Parse(Console.ReadLine());

    }
    public void PrintDetails()
    {
        Console.WriteLine("Person Name is :"+name);
        Console.WriteLine("Person Age is :"+age);
    }

    }
}
