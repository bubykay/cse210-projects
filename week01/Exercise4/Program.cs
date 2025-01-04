List<int> numbers = [];
Console.WriteLine("Enter a list of numbers, type 0 when finished");
int number;

while (true)
{
    Console.Write("Enter number: ");
    number = int.Parse(Console.ReadLine());
    if (number == 0)
    {
        break;
    }
    numbers.Add(number);
}
if (numbers.Count > 0)
{
    numbers.Sort();
    Console.WriteLine("The sum is " + numbers.Sum());
    Console.WriteLine("The average is " + (double)numbers.Sum() / numbers.Count);
    Console.WriteLine("The largest number " + numbers.Max());
    Console.WriteLine("The smallest positive number is: " + numbers.Min());
    Console.WriteLine("The sorted listis ");
    foreach (int num in numbers)
    {
        Console.WriteLine(num);
    }
}