using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidDivide
{
    class Program
    {
        static void Main(string[] args)
        {
            divideByTwo divide2 = new divideByTwo();
            Console.WriteLine("Please enter a number to be divided by two.");
            int number = Convert.ToInt32(Console.ReadLine());
            divide2.mathDivide(number);
            

            divideByTwo decimalDivide2 = new divideByTwo();
            Console.WriteLine("Please enter a decimal number to be divided by another number.");
            float decDivideNum = Single.Parse(Console.ReadLine());
            decimalDivide2.mathDivide(decDivideNum);
            

            Student.studentInfo();
            Console.ReadLine();
        }
    }
}
