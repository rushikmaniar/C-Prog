using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class Prog34
    {
        static void Main(string[] args) {
            Overload obj1 = new Overload();
            Overload obj2 = new Overload();
            Overload obj3 = new Overload();
            Console.WriteLine("Operator Overloading ");
            Console.WriteLine("Enter Two Number :");
            obj1.a = int.Parse(Console.ReadLine());
            obj2.a = int.Parse(Console.ReadLine());

            //Addition
            obj3 = obj1 + obj2;
            Console.WriteLine("Addition : " + obj3.a);

            //Subtration
            obj3 = obj1 - obj2;
            Console.WriteLine("Subtration : " + obj3.a);

            //Multiplication
            obj3 = obj1 * obj2;
            Console.WriteLine("Multiplicaiotn : " + obj3.a);

            //Dividion
            obj3 = obj1 / obj2;
            Console.WriteLine("Division : " + obj3.a);

            //Modules
            obj3 = obj1 % obj2;
            Console.WriteLine("Modules : " + obj3.a);
            
        }
    }
    class Overload {
        public int a;
        public static Overload operator +(Overload obj1, Overload obj2) {
            Overload obj3 = new Overload();
            obj3.a = obj1.a + obj2.a;
            return obj3;
        
        }

        public static Overload operator -(Overload obj1, Overload obj2)
        {
            Overload obj3 = new Overload();
            obj3.a = obj1.a - obj2.a;
            return obj3;

        }

        public static Overload operator *(Overload obj1, Overload obj2)
        {
            Overload obj3 = new Overload();
            obj3.a = obj1.a * obj2.a;
            return obj3;

        }

        public static Overload operator /(Overload obj1, Overload obj2)
        {
            Overload obj3 = new Overload();
            if (obj2.a == 0)
                Console.WriteLine("Division not possible");
            else
            obj3.a = obj1.a / obj2.a;
            return obj3;

        }

        public static Overload operator %(Overload obj1, Overload obj2)
        {
            Overload obj3 = new Overload();
            if (obj2.a == 0)
                Console.WriteLine("Division not possible");
            else
                obj3.a = obj1.a % obj2.a;
            return obj3;

        }
    }
}
