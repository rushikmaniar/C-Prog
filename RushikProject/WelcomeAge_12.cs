using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class WelcomeAge_12
    {
        static void Main(string[] args)
        {
            int age;
            string name;
            System.Console.WriteLine("Enter name : ");
            name = Console.ReadLine();
            System.Console.WriteLine("Enter age : ");
            age = int.Parse(Console.ReadLine());

            if (age > 0 && age < 12)
            {
                Console.WriteLine("Welcome Child "+name);
            }
            else if (age >= 12 && age < 17)
            {
                Console.WriteLine("Welcome Tennage " + name);
            }
            else if (age >= 18 && age < 60)
            {
                Console.WriteLine("Welcome Adult " + name);
            }
            else {
                Console.WriteLine("Welcome Senior Citizen " + name);
            }
        }

    }
}
