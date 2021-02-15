using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparsionpg159
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparision Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            decimal person1HourlyRate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int person1WeeklyHours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            decimal person2HourlyRate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int person2WeeklyHours = Convert.ToInt32(Console.ReadLine());

            decimal person1AnnualSalary = person1HourlyRate * person1WeeklyHours * 52;
            Console.WriteLine("Annual salary of Person 1: ");
            Console.WriteLine(person1AnnualSalary);

            decimal person2AnnualSalary = person2HourlyRate * person2WeeklyHours * 52;
            Console.WriteLine("Annual salary of Person 2: ");
            Console.WriteLine(person2AnnualSalary);

            Console.WriteLine("Does Person 1 make more money than Person 2? ");
            bool makesMore = person1AnnualSalary > person2AnnualSalary;
            Console.WriteLine(makesMore);

            Console.ReadLine();
        }
    }
}
