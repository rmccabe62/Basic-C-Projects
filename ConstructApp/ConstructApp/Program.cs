using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an object by referencing two constructors chained together
            Person pers1 = new Person("Bob");
            //Declare a constant and a assign a value
            const string Name = "Bob Smith";
            //Declare a variable with the datatype var and assign a value to it
            var age = 55;

            Console.WriteLine(pers1.FirstName, pers1.LastName);
            Console.ReadLine();

        }
    }
}
