using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LogText
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get the number from the user
            Console.WriteLine("Please enter a whole number.");
            string answer = Console.ReadLine();

            //Print the number to a log text file
            using (StreamWriter file = new StreamWriter(@"C:\Users\rmcca\OneDrive\Desktop\Logs\log.txt"))
            {
                file.WriteLine(answer);
            }
            //Display the number back to the user
            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }
}
