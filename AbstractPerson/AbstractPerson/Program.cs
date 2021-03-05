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
            List<Things>
           //Create a new object and display the result of a comparision to the screen
            Employee employee = new Employee();
            employee.id =231;
            Employee employee2 = new Employee();
            employee2.id =231;
            Console.WriteLine(employee == employee2);
            Console.WriteLine(employee != employee2);
            Console.ReadLine();

        }
    }
}
