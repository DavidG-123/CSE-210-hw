using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guess the magic number!");
        Console.Write("What is your guess? ");
        Random randNum = new Random();
        int magicNumber = randNum.Next(1,1000);
        int guess = int.Parse(Console.ReadLine());
        while (guess != magicNumber){
            if (guess < magicNumber){
                Console.WriteLine("Higher!");
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
            }
            if (guess > magicNumber){
                Console.WriteLine("Lower!");
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("You guessed it!");
    }
}