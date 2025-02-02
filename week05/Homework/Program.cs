using System;

class Program
{
    static void Main(string[] args)
    {

        Assignment assignment = new Assignment();

        Console.WriteLine("Assignment Summary: " + assignment.GetSummary());
        Console.WriteLine("");
        MathAssigment mathAssigment = new MathAssigment();
        mathAssigment._textBookSection = "Chapter 1";
        mathAssigment._problem = "1-10";
        Console.WriteLine("Math Assignment Summary: " + mathAssigment.GetSummary());
        Console.WriteLine("Math Assignment Summary: " + mathAssigment.GetHomeWorkList());
        Console.WriteLine("");
        WritingAssignment writingAssignment = new WritingAssignment();
        writingAssignment._title = "My First Essay";
        Console.WriteLine("Writing Assignment Summary: " + writingAssignment.GetSummary());
        Console.WriteLine("Writing Assignment Summary: " + writingAssignment.GetWritingInformation());
    }
}