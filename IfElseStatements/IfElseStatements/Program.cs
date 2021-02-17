using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = "banana";

            if (fruit == "apple")
            {
                Console.WriteLine("The fruit is apple");
            }
            else if (fruit == "pear")
            {
                Console.WriteLine("The fruit is pear");
            }
            else if (fruit == "banana")
            {
                Console.WriteLine("The fruit is banana");
            }
            else
            {
                Console.WriteLine("The fruit is not on the list");
            }

            if (50 != 100)
            {
                Console.WriteLine("The staterment is true.");
            }
            else
            {
                Console.WriteLine("The staetment is false.");
            }

            int num1 = 19;
            int num2 = 6;

            if (num1 > num2)
            { 
                Console.WriteLine("The first number is greater than the second number");
            }
            else
            {
                Console.WriteLine("The first number is not greater than the second number");
            }

            if (num1 < num2)
            {
                Console.WriteLine("The first number is less than the second number");
            }
            else
            {
                Console.WriteLine("The first number is not less than the second number");

                int num3 = 4;
                int num4 = 10;

                string answer = num3 > num4 ? "num3 is greater num4" : "num3 is not greater than num4";
                Console.WriteLine(answer);
            }
            Console.ReadLine();

        }
    }
}
