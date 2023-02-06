using System;
using System.IO;

public class RecordWrite 
{
    JournalPrompt Prompt1 = new JournalPrompt();
    AskIterate AskUser = new AskIterate();
    Random rnd = new Random();
    public string Time = (DateTime.Now.Month).ToString() + "-" + (DateTime.Now.Day).ToString() + "-" + (DateTime.Now.Year).ToString();
    public void UserRestart(Boolean WhatBool){
        if (WhatBool == true) {
            AskUser.UserRestart();
        }
        else{
            if (File.Exists("temp.txt")){
                string FileText = File.ReadAllText("temp.txt");
                File.Delete("temp.txt");
                File.WriteAllText($"journal-{Time}-{AskUser.Hours}.txt", FileText);
            }
        }
    }
    public Boolean TheBool(Boolean WhatBool) {
        Boolean UserIterate(Boolean WhatBool){
            if (WhatBool == false) {
                Boolean PromptUser(){
                    Prompt1.AddtoList();
                    string[] response = Prompt1.UserPrompt(Prompt1._Cases.ElementAt(rnd.Next(0,5)));
                    Console.WriteLine("Do you want to record your entry to a new file?");
                    if (AskUser.AskUser() == "yes"){
                        File.WriteAllText("temp.txt", FormatJournal(response));
                        return true;
                    }
                    else {return false;}
                };
                return PromptUser();
            }
            else {
                Boolean NewPromptUser(){
                    Prompt1.AddtoList();
                    string[] response = Prompt1.UserPrompt(Prompt1._Cases.ElementAt(rnd.Next(0,5)));
                    Console.WriteLine("Do you want to add your entry to the file?");
                    if (AskUser.AskUser() == "yes"){
                        string FileText = File.ReadAllText("temp.txt");
                        Console.WriteLine(FileText);
                        File.WriteAllText("temp.txt", (FileText + FormatJournal(response)));
                        return true;
                    }
                    else {return false;}
                };
                return NewPromptUser();
            }
        }
        return UserIterate(WhatBool);    
    }
    string FormatJournal(string[] text){
        Console.Write($"Here's your Journal entry:\n\n\n");
        Console.WriteLine($"\x20\x20\x20\x20{Time}\n\n{text[1]}\n\"{text[0]}\" -User, {(DateTime.Now.Year).ToString()}\n");
        
        return $"\n\n\x20\x20\x20\x20{Time}\n\n{text[1]}\n\"{text[0]}\" -User, {(DateTime.Now.Year).ToString()}\n\n";
    }

}