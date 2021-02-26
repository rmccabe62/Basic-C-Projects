using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleMethodsMath
{
    class mathOverload
    {
        public int mathOperations(int num1)
        {
            int sum = num1 + 10;
            return sum;
        }
        public int mathOperations( decimal num2)
        {
            
            int newNum = Convert.ToInt32(num2);
            int difference = newNum - 3;
            
            return difference;
        }
        public int mathOperations(string year)
        {
            int birthYear = Convert.ToInt32(year);
            
            int age = 2021 - birthYear;
            return age;
        }
    }
}
