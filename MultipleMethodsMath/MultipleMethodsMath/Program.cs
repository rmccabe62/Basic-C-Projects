using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleMethodsMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number that will be used to perform some calculations.");
            int numChoice = Convert.ToInt32(Console.ReadLine());
            mathOverload add = new mathOverload();
            Console.WriteLine("Your number when added to another number is equal to: ");
            Console.WriteLine(add.mathOperations(numChoice));

            Console.WriteLine("Please enter another number to be used as part of an calculation: ");
            decimal numChoice2 = Convert.ToDecimal(Console.ReadLine());
            mathOverload subtract = new mathOverload();
            Console.WriteLine("Another number subtracted from your number is: ");
            Console.WriteLine(subtract.mathOperations(numChoice2));


            
            Console.WriteLine("Please enter the year you were born: ");
            string birthYear = Console.ReadLine();
            mathOverload calcAge = new mathOverload();
            Console.WriteLine(calcAge.mathOperations(birthYear));
            Console.ReadLine();

        }
    }
}
