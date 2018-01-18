using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class Month_13
    {
        static void Main(string[] args) {
            int a;
            Console.WriteLine("Enter no for month :");
            a = int.Parse(Console.ReadLine());
            switch(a){
                case 1:
                    Console.WriteLine("It is January");
                    break;
                case 2:
                    Console.WriteLine("It is February");
                    break;
                case 3:
                    Console.WriteLine("It is March");
                    break;
                case 4:
                    Console.WriteLine("It is April");
                    break;
                case 5:
                    Console.WriteLine("It is May");
                    break;
                case 6:
                    Console.WriteLine("It is June");
                    break;
                case 7:
                    Console.WriteLine("It is July");
                    break;
                case 8:
                    Console.WriteLine("It is August");
                    break;
                case 9:
                    Console.WriteLine("It is September");
                    break;
                case 10:
                    Console.WriteLine("It is October");
                    break;
                case 11:
                    Console.WriteLine("It is November");
                    break;
                case 12:
                    Console.WriteLine("It is Deceber");
                    break;
                default:
                    Console.WriteLine("It is invalid");
                    break;
            
            }
        
        }
    }
}
