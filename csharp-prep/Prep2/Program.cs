using System;

class Program
{
    static void Main(string[] args)
    {   
        string letterGrade = "";
        Console.Write("What is your grade percent value? (write as rounded integer!) "); float grade = Int32.Parse(Console.ReadLine());
        if (grade >= 90) {
            letterGrade = (grade + "%");
        }
        else if (grade < 90 && grade >= 80) {
            letterGrade = (grade + "%");
        }
        else if (grade >= 70) {
            letterGrade = (grade + "%");
        }
        else if (grade >= 60) {
            letterGrade = (grade + "%");
        }
        else if (grade < 60) {
            letterGrade = (grade + "%");
        }


        if (grade >= 70 ) {
            Console.WriteLine($"Your grade is {letterGrade}, you passed!");
        }
        else if (grade < 70) {
            Console.WriteLine($"Your grade is {letterGrade}. You didn't pass, but there's always next time :) !");
        }
    }
}