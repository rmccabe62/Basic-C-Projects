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
            string answer = Console.ReadLine();
            //Append the number chosen to the log file
            using (StreamWriter file = new StreamWriter(@"C:\Users\rmcca\OneDrive\Desktop\Logs\log.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(answer);
            }
        }
    }
}
