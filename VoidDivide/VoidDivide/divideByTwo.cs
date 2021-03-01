using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidDivide
{
    class divideByTwo
    {
        public void mathDivide(int num1)
        {
            int quotient = num1 / 2;
            Console.WriteLine(quotient);
        }
        public void mathMultiply(out int num2, out int num3)
        {
            int temp = 4;
            num2 = temp;
            int temp2 = 6;
            num3 = temp2;

            int product = num2 * num3;
        }
        public void mathDivide(float num5)
        {
            float quotient2 = (float)(num5 / 4.2);
            Console.WriteLine(quotient2);
        }
    }
}
