﻿namespace MultipleChoiceQuestions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            var lastname = Console.ReadLine();

            Console.WriteLine("What is your age?");
            var age = Console.ReadLine();

            Console.WriteLine("What is your birth month?");
            var month = Console.ReadLine();

            Console.WriteLine("What is your birth day?");
            var day = Console.ReadLine();

            // Prints a blank line to make the console look nicer and more readable
            Console.WriteLine("");

            Console.WriteLine("Your full name is: {0} {1}", name, lastname);

            Console.WriteLine("Your age is: {0}", age);

            Console.WriteLine("Your birth month is: {0}", month);

            Console.WriteLine("Your birth day is: {0}", day);



        }
    }
}
