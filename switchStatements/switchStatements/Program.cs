using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 6;
            switch(age)
            {
                case 1:
                    Console.WriteLine("1 is incorrect.");
                    break;
                case 2:
                    Console.WriteLine("2 is incorrect.");
                    break;
                case 3:
                    Console.WriteLine("3 is incorrect.");
                    break;
                case 4:
                    Console.WriteLine("4 is incorrect.");
                    break;
                case 5:
                    Console.WriteLine("5 is incorrect.");
                    break;
                case 6:
                    Console.WriteLine("6 is the correct age.");
                    break;
                case 7:
                    Console.WriteLine("7 is incorrect.");
                    break;
                default:
                    Console.WriteLine("The correct age falls between 1 and 7.");
                    break;

             

            }
            Console.ReadLine();

        }
    }
}
