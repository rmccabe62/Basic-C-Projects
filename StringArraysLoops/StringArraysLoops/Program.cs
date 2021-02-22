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
            bool guess = false;
            while (guess == false)
            {


                Console.WriteLine("Please enter a name to search for in the list: ");

                string nameChoice = Console.ReadLine();

                for (int i = 0; i < names.Count; i++)
                {
                    if (nameChoice == names[i])
                    {
                        Console.WriteLine("That is correct! " + nameChoice + " is in the list at " + i);
                        guess = true;
                        break;

                    }


                }
                if (guess == false)
                {
                    Console.WriteLine("That is an incorrect guess.");
                }
                Console.ReadLine();
            }


            List<string> fruits = new List<string>() { "apple", "pear", "blueberry", "banana", "plum", "blueberry" };
            bool guess2 = false;
            while (guess2 == false)
            {

                Console.WriteLine("Please enter the name of your favorite fruit:");
                string fruitName = Console.ReadLine();
                for (int j = 0; j < fruits.Count; j++)
                {
                    if (fruitName == fruits[j])
                    {

                        Console.WriteLine("That is correct! " + fruitName + " is in the list at " + j);
                        guess2 = true;

                    }
                }
                if (guess2 == false)
                {
                     Console.WriteLine("the fruit you picked isn't on the list. Please try again.");
                     
                }

                Console.ReadLine();
                
            
            }

            List<string> directions = new List<string>() { "start", "stop", "turn left", "turn right", "stop" };
            List<string> directionsCopy = new List<string>();

           

            foreach (string direction in directions)
            {

                foreach (string directionCopy in directionsCopy)
                {
                    if (direction == directionCopy)
                    {
                        Console.WriteLine("This item has appeared before: " + direction);
                    }
                }
            directionsCopy.Add("start");
            directionsCopy.Add("stop");
            directionsCopy.Add("turn left");
            directionsCopy.Add("turn right");
            directionsCopy.Add("stop");

            }



            Console.ReadLine();
        }
    }
}
