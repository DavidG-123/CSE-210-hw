using System;

class Program
{
    static void Main(string[] args)
    {
        static void UserStart() {
            RecordWrite ShallRecord = new RecordWrite();
            Boolean WhatBool = false;
            
            Console.Write($"Do you want to make a journal entry?\n");
            
            string UserAnswer = Console.ReadLine();
            

            if (UserAnswer.ToLower() == "yes" | UserAnswer.ToLower() == "y") {
                WhatBool = ShallRecord.TheBool(WhatBool);
            } else if (UserAnswer.ToLower() == "no" | UserAnswer.ToLower() == "n") {
                Console.WriteLine("Okay, have a nice day!");
            } else {
                Console.WriteLine($"Sorry, your answer was not understood; please answer with \"yes\" or \"no\".");
                UserStart();
            };
            ShallRecord.UserRestart(WhatBool);
        }
        UserStart();
    }
    
}