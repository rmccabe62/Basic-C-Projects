using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] strArray1 = { "Baseball", "Basketball", "Football", "Golf", "Soccer" };

            Console.WriteLine("Please select a number between 0 and 4 to display the name of a random sport.");
            int sportChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(strArray1[sportChoice]);
            

            int[] intArray1 = { 5, 10, 56, 256, 1000 };

            Console.WriteLine("Please select a number between 0 and 4 to display a random number.");
            int numChoice = Convert.ToInt32(Console.ReadLine());
            if (numChoice > 4)
            {
                Console.WriteLine("That is an invalid number. A vailid number is  between 0 and 4.");
                
            }
            else
            {
            
            Console.WriteLine(intArray1[numChoice]);
            
            }

            

            List<string> stringList = new List<string>();
            stringList.Add("John");
            stringList.Add("Robert");
            stringList.Add("Debbie");
            stringList.Add("Cindy");
            stringList.Add("David");
            stringList.Add("Alice");

            Console.WriteLine("Please choose a number between 0 and 5 to display a person's name.");
            int nameChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stringList[nameChoice]);

            Console.ReadLine();

        }

      
    }
}
