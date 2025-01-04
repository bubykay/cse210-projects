using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new();
        int magicNumber =  randomGenerator.Next(1, 4);
        int guessNumber;
        do{
            
            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());
            if(magicNumber == guessNumber){
                Console.WriteLine("You guessed it!");
                break;
            }
            if(guessNumber < magicNumber){
            Console.WriteLine("lesser");
            } else {
                Console.WriteLine("Higher");
            }
        } while (guessNumber != magicNumber);
        
    }
}