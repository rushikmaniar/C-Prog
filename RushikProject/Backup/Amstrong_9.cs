using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RushikProject
{
    class Amstrong_9 {
	public static void Main(string[] args) {
		int a,i;
        //int from, to;
		Console.Write("Enter Number :");
        a = int.Parse(Console.ReadLine());
		Amstrong1 a1 = new Amstrong1();
		i = a1.CheckAmstrong(a);
        if (i == 1)
        {
            Console.WriteLine("It is Amstrong");
        }
        else
        {
            Console.WriteLine("Not Amstrong");
        }
        /*
        Console.Write("Enter From :");
        from = int.Parse(Console.ReadLine());
        Console.Write("Enter to :");
        to = int.Parse(Console.ReadLine());
        Console.WriteLine("Amstrong Numbers :");
        for (int i = from; i < to;i++ ) {
            int j = a1.CheckAmstrong(i);
            if (j == 1)
            {
                Console.Write(" "+i);
            }
            else
            {
                Console.Write("");
            }
        }
        Console.WriteLine();
         */
	}
}

class Amstrong1 {

	public int CheckAmstrong(int a) {
		int digit = getdigit(a);

		double sum = 0;
		int i, r;

		i = a;
		while (i != 0) {
			r = i % 10;
			double temp = Math.Pow(r, digit);
			sum = sum + temp;
			i = i / 10;

		}
        if (sum == a)
        {
            return 1;
            //Console.WriteLine("It is Amstrong");
        }
        else
        {
            return 0;
            //Console.WriteLine("Not Amstrong");
        }

	}

	public int getdigit(int a) {
		int i, digit = 0;

		i = a;
		while (i != 0) {
			// r = i % 10;
			digit++;
			i = i / 10;

		}
		return (digit);
	}
}
}
