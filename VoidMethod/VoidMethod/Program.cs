using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            voidTwoNums mathDisplay = new voidTwoNums();
            Console.WriteLine("Please enter a number to be added to another number. ");
            int enterNum = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Please enter a second number to be displayed to the screen.");
            int secNum =Convert.ToInt32(Console.ReadLine());
            mathDisplay.voidNumbers(enterNum, secNum);
            Console.ReadLine();
            
            
        }
    }
}
