using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        static string gradeCategory(int grade)
        {
            int category = grade % 10;
            if (category >= 7)
            {
                return "+";
            }
            else if (category < 3)
            {
                return "-";
            }
            else
            {
                return "";
            }

        }
        string grade;

        if (percent >= 90)
        {
            grade = "A" + gradeCategory(percent);
        }
        else if (percent >= 80)
        {
            grade = "B" + gradeCategory(percent);
        }
        else if (percent >= 70)
        {
            grade = "C" + gradeCategory(percent);
        }
        else if (percent >= 60)
        {
            grade = "D" + gradeCategory(percent);
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is: {grade}");

        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }

    }
}