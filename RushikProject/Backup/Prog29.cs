using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class Prog29
    {
        static void Main(string[] args)
        {
            SamplePerson[] p1 = new SamplePerson[3];
            
            int count;
            for(int i=0;i<3;i++){
                Console.WriteLine("Person"+i);
                p1[i] = new SamplePerson();
                p1[i].getDetails();
                Console.Write("Enter Income :");
                int inc = int.Parse(Console.ReadLine());
                p1[i].earned(inc);
                Console.Write("Enter Expense :");
                int exp = int.Parse(Console.ReadLine());
                p1[i].spent(exp);
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
    class SamplePerson
    {
        String name;
        int age;
        long income,expense;
        static long balance;
        public static int count;
        public SamplePerson()
        {
            balance = 12000;
            count++;
        }
        public int getPersons()
        {
            return count;
        }
        public void getDetails()
        {
            Console.Write("Enter Name :");
            name = Console.ReadLine();
            Console.Write("Enter Age :");
            age = int.Parse(Console.ReadLine());

        }
        public void earned(long inc)
        {
            income = inc;

        }
        public void spent(long exp)
        {
            expense = exp;

        }

        public void PrintDetails()
        {
            balance = income - expense;
            Console.WriteLine("Person Name is :" + name);
            Console.WriteLine("Person Age is :" + age);
            Console.WriteLine("Person Income is :" + income);
            Console.WriteLine("Person Expense is :" + expense);
            Console.WriteLine("Person Balance is :" + balance);
        }

    }
}
