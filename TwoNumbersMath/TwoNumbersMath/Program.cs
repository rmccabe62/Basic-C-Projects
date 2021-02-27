using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoNumbersMath
{
    class Program
    {
        static void Main(string[] args)
        {
            dbleMath divide  = new dbleMath();

            Console.WriteLine("Please enter a number to be divided by another number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number if you wish. It is not required.");
            string num2 = Console.ReadLine();
            if (num2 == "")
            {
                Console.WriteLine(divide.optSecond(num1));
            }
            else
            {
                int num2int = Convert.ToInt32(num2);
                int quotient = divide.optSecond(num1,num2int);
                Console.WriteLine("Your number divided by another number is: ");
                Console.WriteLine(quotient);
            }
            Console.ReadLine();

            
            
            
          
           





        }
    }
}
