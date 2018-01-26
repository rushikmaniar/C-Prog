using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class ExaParams_J18_32
    {
        public static void Main(string[] args)
        {
            int min, max;
            get_min_max(out min, out max, 5, 4, 3, 9);
            Console.WriteLine("Min :" + min + "\nMax : " + max);

        }
        public static void get_min_max(out int min, out int max, params int[] arr)
        {
            min = arr[0];
            max = arr[0];
            foreach (int value in arr)
            {
                if (value > max)
                {
                    max = value;
                }
                if (value < min)
                {
                    min = value;
                }
            }
        }
    }
}
