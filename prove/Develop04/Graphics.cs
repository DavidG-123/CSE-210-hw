using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;

public class Graphics {
    private string _RGBseq;
    private List<string> _responses;
    private static string _listThis;
    private static List<string> _messageBoard = new List<string>
    {
    $"Welcome to the Good-Minded Mindfulness(tm) network!\n",//0
    $"Welcome, let's begin our breathing exercise.\n",//1
    $"That was fun!\n",//2
    $"Welcome, let's begin our reflection exercise.\n",//3
    $"{_reflectQuestion()}\n",//4
    $"\n\n\n",//5
    $"(think) How does that experience matter to you?\n",//6
    $"(think) How did you feel when it was over?\n",//7
    $"(think) What is your favorite thing about that experience?\n",//8
    $"(think) What did you learn from that experience?\n",//9
    $"{_listingQuestions()}\n",//10
    $"Now in your head list as many of these as you can.\n",//11
    $"You listed {_listThis} things.\n",//12
    $"Welcome, let's begin our Listing exercise.\n",//13
    $"Good job!\n*Returning to menu**"//14
    };
    private static string _reflectQuestion() {
        Random random = new Random();
        string[] question = {
        "Think of a time that you stubbed your toe.",
        "Think about a time that you helped someone with a task.",
        "Think about a time when you felt socially surrounded by friends.",
        "Think about a time when you felt relaxed and peaceful."
        };
        return(question[random.Next(0,3)]);
    }
    private static string _listingQuestions() {
        Random random = new Random();
        string[] question = {
        "Who are some of the people that you appreciate?",
        "What are some of your personal strengths?",
        "What are the names of people who have encouraged or helped you this week?",
        "When were times that you felt the holy spirit this month?",
        "Who are some of your personal role models?"
        };
        return(question[random.Next(0,3)]);
    }

    public string[] Colors = {
        $"\u25A0              ",
        $" \u25A0             ",
        $"  \u25A0            ",
        $"   \u25A0           ",
        $"    \u25A0          ",
        $"     \u25A0         ",
        $"      \u25A0        ",
        $"       \u25A0       ",
        $"        \u25A0      ",
        $"         \u25A0     ",
        $"          \u25A0    ",
        $"           \u25A0   ",
        $"            \u25A0  ",
        $"             \u25A0 ",
        $"              \u25A0"
    };
    public void triangleAnimation() {
        Console.Clear();
        Console.Write($"\n\n\n\n\n\n\n{Colors[2]} ~rest"); Thread.Sleep(500); Console.Clear();
        Console.Write($"\n\n\n\n\n\n\n{Colors[4]} ~rest"); Thread.Sleep(500); Console.Clear();
        Console.Write($"\n\n\n\n\n\n\n{Colors[6]} ~rest"); Thread.Sleep(500); Console.Clear();
        Console.Write($"\n\n\n\n\n\n\n{Colors[8]} ~rest"); Thread.Sleep(500); Console.Clear();
        Console.Write($"\n\n\n\n\n\n\n{Colors[10]} ~rest"); Thread.Sleep(500); Console.Clear();
        Console.Write($"\n\n\n\n\n\n\n{Colors[12]} ~rest"); Thread.Sleep(500); Console.Clear();
        Console.Write($"\n\n\n\n\n\n\n{Colors[14]} ~rest"); Thread.Sleep(500); Console.Clear();
        Console.Write($"\n\n\n\n\n\n{Colors[13]}\n                ~breathe in"); Thread.Sleep(500); Console.Clear();
        Console.Write($"\n\n\n\n\n{Colors[12]}\n\n                ~breathe in"); Thread.Sleep(500); Console.Clear();
        Console.Write($"\n\n\n\n{Colors[11]}\n\n\n                ~breathe in"); Thread.Sleep(500); Console.Clear();
        Console.Write($"\n\n\n{Colors[10]}\n\n\n\n                ~breathe in"); Thread.Sleep(500); Console.Clear();
        Console.Write($"\n\n{Colors[9]}\n\n\n\n\n                ~breathe in"); Thread.Sleep(500); Console.Clear();
        Console.Write($"\n{Colors[8]}\n\n\n\n\n\n                ~breathe in"); Thread.Sleep(500); Console.Clear();
        Console.Write($"{Colors[7]}\n\n\n\n\n\n\n                ~breathe in"); Thread.Sleep(500); Console.Clear();
        Console.Write($"\n{Colors[6]}\n\n\n\n\n\n                ~breathe out"); Thread.Sleep(500); Console.Clear();
        Console.Write($"\n\n{Colors[5]}\n\n\n\n\n                ~breathe out"); Thread.Sleep(500); Console.Clear();
        Console.Write($"\n\n\n{Colors[4]}\n\n\n\n                ~breathe out"); Thread.Sleep(500); Console.Clear();
        Console.Write($"\n\n\n\n{Colors[3]}\n\n\n                ~breathe out"); Thread.Sleep(500); Console.Clear();
        Console.Write($"\n\n\n\n\n{Colors[2]}\n\n                ~breathe out"); Thread.Sleep(500); Console.Clear();
        Console.Write($"\n\n\n\n\n\n{Colors[1]}\n                ~breathe out"); Thread.Sleep(500); Console.Clear();
        Console.Write($"\n\n\n\n\n\n\n{Colors[0]} ~breathe out"); Thread.Sleep(500); Console.Clear();
    }

    public static void MessageBoard(List<int> messages) {
        Console.Clear();
        foreach (int e in messages) {
            Console.Write(_messageBoard[e]);
            Thread.Sleep(750);
        }
    }
    public void Loading() {
        Thread.Sleep(5000);
        //List<int> thirtySec = new List<int>{30,29,28,27,26,25,24,23,22,21,20,19,18,17,16,15,14,13,12,11,10,9,8,7,6,5,4,3,2,1};
        List<int> fifteenSec = new List<int>{15,14,13,12,11,10,9,8,7,6,5,4,3,2,1};
        foreach (int e in fifteenSec) {
            Console.Clear();
            if (e == 30|e == 26|e == 22|e == 18|e == 14|e == 10|e == 6|e == 2){
                Console.Write($"Think / {e}");
            }
            else if (e == 29|e == 25|e == 21|e == 17|e == 13|e == 9|e == 5|e == 1) {
                Console.Write($"Think | {e}");
            }
            else if (e == 28|e == 24|e == 20|e == 16|e == 12|e == 8|e == 4) {
                Console.Write($"Think \x5C {e}");
            }
            else {
                Console.Write($"Think \u2500 {e}");
            }
            Thread.Sleep(1000);
        }
    }
    public void ListThis() {
        string e = "";
        int count = 0;
        while (true) {
            Console.Clear();
            Console.Write($"Now list one and press enter:\n(This will repeat the list and you can enter as\nmany as you want. When your finished, type {"\x22"}done\x22.)\n");
            string y = Console.ReadLine();
            if (y == "done") {
                    break;
            }
            else {
                e += (y + " ");
            }
        }
        foreach (var ch in e) {
            if (ch == ' ') {
                count++;
            }
        }
        _listThis = $"{count}";
        Console.Write($"You listed {_listThis} things.\n");
        Waiting();
    }
    public static void Waiting() {
        Thread.Sleep(5000);
    }
    public void RecordResponse(string response){
        _responses.Add(response);
    }
}