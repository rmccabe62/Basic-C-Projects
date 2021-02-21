using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArraysLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nyCities = { "Albany", "Binghamton", "Delhi", "New York", "Syracuse" };
            Console.WriteLine("Please enter any New York city that you wish: ");
            string cityChoice = Console.ReadLine();

            for (int i = 0; i < nyCities.Length; i++)
            {
                nyCities[i] += cityChoice;
            }
            for (int i = 0; i < nyCities.Length; i++)
            { 
                Console.WriteLine(nyCities[i]);
            }
            for (int j = 0; j < 20; j++)
            {
                Console.WriteLine("value: {0}", j);
            }
            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine("number is: {0}", k);
            }
            for (int m = 0; m <= 8; m++)
            {
                Console.WriteLine("number is: {0}", m);
            }

            List<string> names = new List<string>() { "Sue", "James", "Linda", "Brad", "Donna" };

            Console.WriteLine("Please enter a name to search for in the list: ");
            string nameChoice = Console.ReadLine();
            foreach (string name in names)
            {
                if (nameChoice != name)
                {
                    Console.WriteLine(nameChoice + "does not match the value of an element in the list");
                }
                else
                {
                    Console.WriteLine(name);
                }
            } 

            Console.ReadLine();

        }
    }
}
