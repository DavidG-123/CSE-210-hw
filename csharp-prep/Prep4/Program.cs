using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number: ");
        string userNumber = Console.ReadLine();
        List<int> numbers = new List<int>();
        numbers.Add(Int16.Parse(userNumber));
        AddIt(numbers);
    }
    static void Product(List<int> args)
    {
        int sum = 0;
        foreach (int additive in args)
        {
            sum += additive;
        }
        int max = args[0];
        foreach (int number in args)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum/args.Count}");
        Console.WriteLine($"The largest number is: {max}");

    }
    static void AddIt(List<int> args){
        Console.Write("Enter number: ");
        int userNumber = Int16.Parse(Console.ReadLine());
        if (args[(args.Count)-1] == 0){
            Product(args);
        }
        else if (userNumber != 0)
        {
            args.Add(userNumber);
            AddIt(args);
        }
        else {
            Product(args);
        }
        
    }
}