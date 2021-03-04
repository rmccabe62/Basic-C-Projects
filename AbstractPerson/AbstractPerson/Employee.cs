using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPerson
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
        public void Quit(Person employee)
        {
            
            Console.WriteLine("Do you want to quit? Please answer true or false. ");
            bool answer = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("You chose: " + answer);
           
        }
        
        
    }
}
