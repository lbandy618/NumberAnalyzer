using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // intro
            Console.WriteLine("Hello, What is your name?");
            string name = Console.ReadLine();
            string userChoice = "y";
            do
            {
                bool gettingValidNumber = true;
                int userNumber = 0;
                Console.WriteLine();
                while (gettingValidNumber)
                {
                    Console.WriteLine("Please enter an integer between 1 and 100.");
                    userNumber = int.Parse(Console.ReadLine());
                    if (userNumber > 0 && userNumber < 101)
                    {
                        gettingValidNumber = false;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input entered. Please try again.");
                    }
                    Console.WriteLine();
                }
                // conditionals 
                if (userNumber < 60 && !(userNumber % 2 == 0))
                {
                    Console.WriteLine("Thank you " + name + " " + userNumber + " is odd and less than 60.");
                }
                if (userNumber >= 2 && userNumber <= 24 && userNumber % 2 == 0)
                {
                    Console.WriteLine("Thank you " + name + " " + userNumber + " is even and less than 25.");
                }
                if (userNumber >= 26 && userNumber <= 60 && userNumber % 2 == 0)
                {
                    Console.WriteLine("Thank you " + name + " " + userNumber + " is even and between 26 and 60 inclusive.");
                }
                if (userNumber >= 60 && userNumber % 2 == 0)
                {
                    Console.WriteLine("Thank you " + name + " " + userNumber + " is even and greater than 60.");
                }
                if (userNumber > 60 && !(userNumber % 2 == 0))
                {
                    Console.WriteLine("Thank you " + name + " " + userNumber + " is odd and greater than 60.");
                }

                // Outro question loop
                Console.WriteLine();    
                Console.WriteLine("Would you like to continue? (y/n)?");
                userChoice = Console.ReadLine();
            } while (userChoice == "y");


        }
    }
}
