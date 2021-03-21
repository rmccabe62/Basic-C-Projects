using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructApp
{
    class Person
    {
        //Set property for the variables
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Create first constructor for the object
        public Person(string strFirst, string strLast)
        {
            this.FirstName = strFirst;
            this.LastName = strLast;
        }
        //Create second constructor for the object
        public Person(string strFirst) : this(strFirst, "Smith")
        {

        }
    }
}
