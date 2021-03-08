using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPerson
{
    public class Program
    {
        static void Main(string[] args)
        {
            
           ////Create a new object and display the result of a comparision to the screen
           // Employee<string> employee = new Employee<string>();
           // //create list of strings using generics to be iterated through
           // employee.Things = new List<string>() { "apple", "cherry", "grapes" };
           // Employee<int> employee1 = new Employee<int>();
           // employee1.Things = new List<int>() { 2, 4, 6, 8 };
           // //iterate through list and display each to the screen
           // foreach (string fruit in employee.Things)
           // {
           //     Console.WriteLine(fruit);
           // }
           // foreach (int num in employee1.Things)
           // {
           //     Console.WriteLine(num);
           // }
           // //Employee employee2 = new Employee();
           // //employee2.id =231;
           // //Console.WriteLine(employee == employee2);
           // //Console.WriteLine(employee != employee2);


            //Get valid user input for a day of the week
            Console.WriteLine("Please enter the current day of the week: ");
            string currentDay = Console.ReadLine();
            //Try to get correct day of the week from the user and display it to the screen
            try
            {
                DaysOfWeek day = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), currentDay);
                Console.WriteLine(day);
            }
            //Display error message if user input is invalid
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                
            }
           
            Console.ReadLine();

        }
        public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

    }
}
