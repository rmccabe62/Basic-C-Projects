using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = new List<int>() { 2, 14, 18, 54, 60 };

                Console.WriteLine(" Please enter a number to be used to divide by numbers in the list.");
                int numChoice = Convert.ToInt32(Console.ReadLine());

                foreach (int number in numbers)
                {
                    float quotient = number / numChoice;
                    Console.WriteLine(number + " divided by " + numChoice + " is equal to " + quotient);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("That is an invalid entry. Pleasae use only whole numbers.");
            }
            Console.WriteLine("Thank you for using this program.");
            
            Console.ReadLine();
           
        }
    }
}
