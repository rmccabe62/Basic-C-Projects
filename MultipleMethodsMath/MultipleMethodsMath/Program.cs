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

            mathOverload subtract = new mathOverload();
            Console.WriteLine("Another number subtracted from your number is: ");
            Console.WriteLine(subtract.mathOperations(numChoice));
            Console.ReadLine();

        }
    }
}
