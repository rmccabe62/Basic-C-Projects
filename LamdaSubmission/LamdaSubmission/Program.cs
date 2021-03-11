using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list of ten employess along with their id's
            List<Employee> empList = new List<Employee>()
            {
                new Employee {firstName = "Bob", lastName = "Smith", Id = 10},
                new Employee {firstName = "Sue", lastName = "Taylor", Id = 11},
                new Employee {firstName = "Joe", lastName = "Jones", Id = 12},
                new Employee {firstName = "Betty", lastName = "Runder", Id = 4},
                new Employee {firstName = "Tom", lastName = "Peters", Id = 3},
                new Employee {firstName = "Jennifer", lastName = "Lyons", Id = 17},
                new Employee {firstName = "Russell", lastName = "Chratch", Id = 2},
                new Employee {firstName = "Bonnie", lastName = "Franks", Id = 15},
                new Employee {firstName = "Joe", lastName = "Brett", Id = 1},
                new Employee {firstName = "Donna", lastName = "Florence", Id = 9}


            };
            // create a list of employess named Joe and iterate through displaying their names
            List<Employee> joeList = new List<Employee>();
            
            joeList = empList.Where(x => x.firstName == "Joe").ToList();
            foreach (Employee joe in joeList)
            {
                Console.WriteLine(joe.firstName);
            }
            List<Employee> employeeList = new List<Employee>();

            // Create an employee list for employess with all id's greater than five and display to the console
           employeeList = empList.Where(y => y.Id > 5).ToList();
            foreach (Employee employee in employeeList)
            {
                Console.WriteLine(employee.firstName + " " + employee.lastName + " " + " " + employee.Id);
            }
            
            
            //foreach ( Employee employee in empList)
            
            
            ////{
            ////    if (employee.firstName == "Joe")
            ////    {
            ////        joeList.Add(employee);
            ////        Console.WriteLine(employee.firstName + " " +  employee.lastName  + " " +  employee.Id);
            ////    }
                
                
            //}
            Console.ReadLine();
        }
    }
}
