using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
        PromptUserName();
    }
    static void PromptUserName()
    {
        Console.Write($"Please enter your name: ");
        string[] name = {Console.ReadLine()};
        PromptUserNumber(name);
    }
    static void PromptUserNumber(string[] args)
    {
        Console.Write($"Please enter your favorite number: ");
        string[] favoriteNumber = {args[0], Console.ReadLine()};
        SquareNumber(favoriteNumber);
    }
    static void SquareNumber(string[] args)
    {
        int squareNumber = ((Int16.Parse(args[1]))*(Int16.Parse(args[1])));
        args[1] = (squareNumber.ToString());
        DisplayResult(args);
    }
    static void DisplayResult(string[] args)
    {
        Console.Write($"{args[0]}, the square of your number is {args[1]}");
    }
}