using System;

public class AskIterate
{
    public string AskUser(){
        string answer = Console.ReadLine();
        if (answer.ToLower() == "yes" | answer.ToLower() == "y") {
            return "yes";
        } else if (answer.ToLower() == "no" | answer.ToLower() == "n") {
            return "no";
        } else {
            Console.WriteLine($"Sorry, your answer was not understood; please answer with \"yes\" or \"no\".");
            AskUser();
        };
        return answer;
    }
    public string Hours = (DateTime.Now.Hour).ToString() + "-" + (DateTime.Now.Minute).ToString();
    public void UserRestart() {
            Boolean WhatBool = true;
            RecordWrite ShallRecord = new RecordWrite();
            
            Console.Write($"Do you want to make another journal entry?\n");
            string UserAnswer = Console.ReadLine();
                      

            if (UserAnswer.ToLower() == "yes" | UserAnswer.ToLower() == "y") {
                WhatBool = ShallRecord.TheBool(WhatBool);
            } else if (UserAnswer.ToLower() == "no" | UserAnswer.ToLower() == "n") {
                Console.WriteLine("Okay, have a nice day!");
                string FileText = File.ReadAllText("temp.txt");
                File.WriteAllText($"journal-{ShallRecord.Time}-{Hours}.txt", FileText);
                File.Delete("temp.txt");
                WhatBool = false;
            } else {
                Console.WriteLine($"Sorry, your answer was not understood; please answer with \"yes\" or \"no\".");
                UserRestart();
            };

            if (WhatBool == true) {ShallRecord.UserRestart(WhatBool);}
            else if (WhatBool == false) {ShallRecord.UserRestart(WhatBool);}
    }
}