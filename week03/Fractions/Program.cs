using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new(3, 4);
        Console.WriteLine(fraction.GetFrachtionString());
        Console.WriteLine(fraction.GetDecimalValue());
    }
}