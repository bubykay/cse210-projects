using System;

class Program
{
    static void Main(string[] args)
    {
        static void logMessage(string message)
        {
            Console.Write(message);
        };
        static void DisplayWelcome()
        {
            logMessage("Welcome to the program!");
            logMessage("\n");
        }
        static string PromptUserName()
        {
            logMessage("Please enter your name: ");
            return Console.ReadLine();
        }
        static int PromptUserNumber()
        {
            logMessage("Please enter your favorite number: ");
            return int.Parse(Console.ReadLine());
        }
        static void DisplayResult(string name, int squareNumber)
        {
            logMessage(name + ", the square of your number is " + squareNumber);
            logMessage("\n");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        DisplayResult(name, number * number);

    }
}