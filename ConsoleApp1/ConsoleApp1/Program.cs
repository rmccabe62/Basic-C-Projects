using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display the date and time to the console
            Console.WriteLine(DateTime.Now);
            //Get the number from the user
            Console.WriteLine("Please enter a whole number.");
            int answer = Convert.ToInt32(Console.ReadLine());
            DateTime currentTime = DateTime.Now;
            DateTime xHoursLater = currentTime.AddHours(answer);
            //For reference
            Console.WriteLine("In " + answer  + " hours it will be " + xHoursLater);
            Console.WriteLine("In {0} hours it will be {1} ", answer, xHoursLater);
            Console.ReadLine();
        }
    }
}
