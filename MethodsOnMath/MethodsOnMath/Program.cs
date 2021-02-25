using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsOnMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to be used in arithmatic operations.");
            int numChoice = Convert.ToInt32(Console.ReadLine());
            mathOperations math = new mathOperations();
            Console.WriteLine("Your number when added to another number is: ");
            Console.WriteLine(math.AddNumber(numChoice));

            Console.WriteLine("Your number when subtracted from another number is: ");
            Console.WriteLine(math.SubtNumber(numChoice));

            Console.WriteLine("Your number when multipled by another number is: ");
            Console.WriteLine(math.multNumber(numChoice));
            Console.ReadLine();
        }
       
    }
}
