using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            

            
            Console.WriteLine("What is your name? ");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);


            
            Console.WriteLine("What course are you on? ");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("Your current course is: " + yourCourse);
            

            Console.WriteLine("What page number?");
            int pageNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The page number is: " + pageNum);
           

            Console.WriteLine("Do you need help with anything? Please answer true or false");
            string ansChoice = Console.ReadLine();
            Console.WriteLine("You answered: " + ansChoice);
            

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string posExp = Console.ReadLine();
            Console.WriteLine("Positive experiences: " + posExp);
            

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedbckInfo = Console.ReadLine();
            Console.WriteLine("Your feedback is: " + feedbckInfo);
            

            Console.WriteLine("How many hours did you study today?");
            int stdyHrs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You studied for " + stdyHrs + " hours today.");
            

            Console.WriteLine("Thank you for your answers. An instuctor will respond to this shortly. Have a great day!");
            Console.ReadLine();


        }
    }
}
