﻿using System;

namespace myConsoleProject.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            String name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            Console.Read();
        }
    }
}
