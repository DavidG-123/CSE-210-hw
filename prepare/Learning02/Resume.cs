using System;

public class Resume
{
    public string _usersName;
    public List<Job> _jobs = new List<Job>();
    public void Display()
    {
        Console.WriteLine($"Name: {_usersName}\n\nJobs: ");
        _jobs[0].DisplayJobInfo();
        _jobs[1].DisplayJobInfo();        
    }
}