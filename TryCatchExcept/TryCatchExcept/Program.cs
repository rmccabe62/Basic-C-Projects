using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchExcept
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the age from the user
            Console.WriteLine("Please enter your age.");
            
            //Validate the user input to calulate their date of birth
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0)
                {
                    throw new ArgumentException();
                }
                DateTime current = DateTime.Now;
                DateTime dateOfBirth = current.AddYears(-age);
                Console.WriteLine(dateOfBirth);
            }
            
            //Check to make sure the input is within the required parameters and output error messages if needed
            catch(ArgumentException)
            {
               
                Console.WriteLine("You entered an incorrect age. Your age must be greater than 0.");
                Console.ReadLine();
                return;
            }
             catch(Exception)
            {
                Console.WriteLine("You entered an invalid response that was not an age that is  greater than 0.");
                Console.ReadLine();
                return;
            }
            Console.ReadLine();    
        }
                
    }

                
                    
            
}
