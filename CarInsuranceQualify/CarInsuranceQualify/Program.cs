using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceQualify
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 15)
            { 
                Console.WriteLine("You are not old enough to qualify.");
            }
            Console.ReadLine();
            Console.WriteLine("Have you ever had a DUI? Please answer true or false.");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quqlified?");
            bool qualify = dui == false && tickets < 4;
            Console.WriteLine(qualify);
            Console.ReadLine();

        }
    }
}
