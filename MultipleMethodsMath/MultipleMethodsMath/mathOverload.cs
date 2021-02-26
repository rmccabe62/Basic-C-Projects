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
        public int mathOperations(int num1, double num2)
        {
            double difference = num2 - 2;
            int newNum = Convert.ToInt32(difference);
            return newNum;
        }
    }
}
