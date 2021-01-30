using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Get a number from the user, multiply it by 50 and print it to the screen
            Console.WriteLine("Please enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int product = num1 * 50;
            Console.WriteLine("The number you entered multiplied by 50 is: ");
            Console.WriteLine(product);
            
            // Get a number from the user, and add 25 to it and print the sum to the screen
            Console.WriteLine("Please enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num2 + 25;
            Console.WriteLine("The number you entered plus 25 is: ");
            Console.WriteLine(sum);
            
            // Get a number from the user, divide it by 12.5 and print the quotient to the screen
            Console.WriteLine("Please enter a number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            float quotient = num3 / 12.5f;
            Console.WriteLine("The number you entered divided by 12.5 is: ");
            Console.WriteLine(quotient);
            
            // Get a number from the user, determine if it is  greater than 50 and print true or false to the screen
            Console.WriteLine("Please enter a number: ");
            int num4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number you entered is greater than 50. The answer is either true or false. ");
            bool greaterthan = num4 > 50;
            Console.WriteLine(greaterthan);
            
            // Get a number from the user, determine the remainder after dividing it by 7 and print the remainder to the screen
            Console.WriteLine("Please enter another number: ");
            int num5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number you entered divided by 7 has a remainder of ");
            int remainder = num5 % 7;
            Console.WriteLine(remainder);
            Console.ReadLine();

            
            
        }
    }
}
