using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What do you wan't to be the fraction's Numerator? (If you wish to not set this, press enter) ");
        
        FractionContainer case1 = new FractionContainer();
        string response = Console.ReadLine();
        
        case1.setFract(response);
        
        if (response.Length == 0) {
            Console.Write("What do you wan't to be the fraction's Denominator? (If you wish to not set this, press enter) ");
            case1.setFract(response, Console.ReadLine());
        }
        case1.GetFractionString();
        case1.GetDecimalValue();
    }
}