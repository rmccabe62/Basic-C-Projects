using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPerson
{
    public class Employee<T> : Person, IQuittable
    {


        public List <T>Things { get; set; } //set the generic property for the method
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
        public void Quit(Person employee) //create a method to allow the user to quit the program
        {

            Console.WriteLine("Do you want to quit? Please answer true or false. ");
            bool answer = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("You chose: " + answer);

        }
        //public static bool operator ==(Employee name1, Employee name2) //establish a comparisiom to see if two employee objects have identicvcal id's
        //{
        //    bool same = (name1.id == name2.id);
        //    return (same);
        //}
        //public static bool operator !=(Employee name1, Employee name2) //compare two employee objects to check if they are not identical
        //{
        //    bool same = (name1.id != name2.id);
        //    return (same);
        //}
        




    }
}
