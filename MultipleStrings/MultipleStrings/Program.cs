using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello, how are you? " + "What are your plans today? " + "Well, have a good day!";

            Console.WriteLine(greeting);
            

            string warning = "Look out behind you!";
            string upperwarning = warning.ToUpper();

            Console.WriteLine(upperwarning);
           

            StringBuilder sb = new StringBuilder();
            sb.Append("\t Be careful!");
            sb.Append(" The weather is bad out there.");
            sb.Append("The roads are very slippery.");
            sb.Append("\n There are many reports of accidents.");
            sb.Append("Drive as slowly as possible.");
            sb.Append("It is not worth risking your life to get to your destination quickly.");
            sb.Append("I have had bad experiences in the past with weather like this.");
            Console.WriteLine(sb);

            Console.ReadLine();
        }
    }
}
