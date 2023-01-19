using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Welcome to Resume Engine(TM)\n\n");
        
        Job job1 = new Job();
        job1._jobTitle = "Brick Layer";
        job1._company = "OSHA";
        job1._startDate = "2003";
        job1._endDate = "2018";
        
        Job job2 = new Job();
        job2._jobTitle = "Bomb Squad K-9 Handler";
        job2._company = "US Army";
        job2._startDate = "2018";
        job2._endDate = "2023";


        Resume myResume = new Resume();
        myResume._usersName = "Ally Caustik";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        
        myResume.Display();
    }
    
    // static void (string[] args)
    // {
    //     Console.Write("What is your job title? ");
    //     string jobValue = Console.ReadLine();
    //     Console.Write("What company do you work for? ");
    //     string companyName = Console.ReadLine();
    //     Console.Write("What year did you start? ");
    // }
}