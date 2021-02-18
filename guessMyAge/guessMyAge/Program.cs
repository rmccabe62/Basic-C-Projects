using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessMyAge
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What state do you think I am from?");
            
            Console.WriteLine("Guess my age.");
            int age = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = age == 58;

            while(!isGuessed)
            {
                switch (age)
                {
                    case 35:
                        Console.WriteLine("You guessed 35.Try again.");
                        Console.WriteLine("Guess my age.");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 40:
                        Console.WriteLine("You guessed 40. Try again.");
                        Console.WriteLine("Guess my age.");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 61:
                        Console.WriteLine("You guessed 61. Try again.");
                        Console.WriteLine("Guess my age.");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed my age as 58. That is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess my age.");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            do
            {
                switch (age)
                {
                    case 35:
                        Console.WriteLine("You guessed 35.Try again.");
                        Console.WriteLine("Guess my age.");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 40:
                        Console.WriteLine("You guessed 40. Try again.");
                        Console.WriteLine("Guess my age.");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 61:
                        Console.WriteLine("You guessed 61. Try again.");
                        Console.WriteLine("Guess my age.");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed my age as 58. That is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess my age.");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                }

            }
            while (!isGuessed);




            Console.ReadLine();
        }
    }
}
    }
}
