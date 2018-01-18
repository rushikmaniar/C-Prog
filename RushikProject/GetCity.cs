using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class GetCity
    {
        static void Main(string[] args)
        {
            Console.Write(" \n\n");

            String[] city = new String[5];
            Console.WriteLine("Enter 10 Cities ");
            for (int i = 0; i < city.Length; i++) {
                city[i] = Console.ReadLine();
            }
            /*Console.Write("\n\nPrinting Cities ");
            for (int i = 0; i < city.Length; i++)
            {
                Console.WriteLine(city[i]);
            }*/
            Console.WriteLine("\n\nPrinting Cities After Sorting");
            for(int i=0;i<city.Length-1;i++){
                for (int j = i + 1; j < city.Length;j++){
                    if(String.CompareOrdinal(city[i],city[j]) > 0){
                        String temp = city[i];
                        city[i] = city[j];
                        city[j] = temp;
                    }
                }
            }
            for (int i = 0; i < city.Length; i++)
            {
                Console.WriteLine(city[i]);
            }
                Console.Write(" \n\n");
        }

    }
}
