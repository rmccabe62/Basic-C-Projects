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
            bool answer = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Do you want to quit? Please answer true or false. ");
            Console.WriteLine(answer);
            Console.ReadLine();
        }
        
        
    }
}
