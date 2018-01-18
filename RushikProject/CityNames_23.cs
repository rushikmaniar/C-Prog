using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class CityNames_23
    {
        static void Main(string[] args)
        {
            Console.Write(" \n\n");

            String[] city = new String[10];
            Console.WriteLine("Enter 10 Cities ");
            for (int i = 0; i < city.Length; i++)
            {
                city[i] = Console.ReadLine();
            }
            Console.Write("\n\nPrinting Cities ");
            for (int i = 0; i < city.Length; i++)
            {
                Console.WriteLine(city[i]);
            }
            Console.Write(" \n\n");
        }
    }
}
