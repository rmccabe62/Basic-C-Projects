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
           
            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.SayName();
            IQuittable quittable = new Employee();
            quittable.Quit(employee);
            Console.ReadLine();
        }
    }
}
