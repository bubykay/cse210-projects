using System;
using System.Linq.Expressions;

class Program
{

    static void Main(string[] args)
    {
        int option;
        Journal journal = new();
        PromptGenerator promptGenerator = new();

        while (true)
        {
            journal.JournalMenu();

            if (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("\nInvalid input. Please enter a number between 1 and 5.\n");
                continue;
            }

            journal._option = option;

            switch (option)
            {
                case 1:
                    string prompt = promptGenerator.GetRandomPrompt();
                    journal.WriteToJournal(prompt);
                    break;
                case 2:
                    journal.DisplayJournal();
                    break;
                case 3:
                    journal.LoadJournal();
                    break;
                case 4:
                    journal.SaveJournal();
                    break;
                case 5:
                    Console.WriteLine("Exiting the journal application.");
                    return;
                default:
                    Console.WriteLine("\nMenu option can only be one of 1 to 5. Please try again.\n");
                    break;
            }
        }
    }
}