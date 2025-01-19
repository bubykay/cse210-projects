using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new(1, 3);
        Console.WriteLine(fraction.GetFrachtionString());
        Console.WriteLine(fraction.GetDecimalValue());
    }
}