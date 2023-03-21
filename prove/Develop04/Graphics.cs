using System;
using System.Collections.Generic;
using System.Threading;

public class Graphics {
    private string _RGBseq;
    private List<string> _responses;
    private List<string> _messageBoard = new List<string>
    {$"Welcome to the Good-Minded Mindfulness\u1d57\u1d50 network!\n",
    $"Let's start with breathing:\n",
    $"That was fun!\n",
    $"Now time to reflect.\n",
    $"{_reflectQuestion()}\n",
    $"\n\n\n",
    $"How does that experience matter to you?\n",
    $"How did you feel when it was over?\n",
    $"What is your favorite thing about that experience?\n",
    $"What did you learn from that experience?\n",
    $"{_listingQuestions()}\n",
    $""
    };
    private static string _reflectQuestion() {
        Random random = new Random();
        string[] question = {
        "Think of a time that you stubbed your toe.",
        "Think about a time that you helped someone with a task.",
        "Think about a time when you felt social and surrounded by friends.",
        "Think about a time when you felt relaxed and peaceful."
        };
        return(question[random.Next(0,3)]);
    }
    private static string _listingQuestions() {
        Random random = new Random();
        string[] question = {
        "Who is someone that you appreciate?",
        "What is one of your personal strengths?",
        "What is the name of someone who has encouraged or helped you this week?",
        "When was a time that you felt the holy spirit this month?",
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

    public void MessageBoard(List<int> messages) {
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
    public void Waiting() {
        Thread.Sleep(5000);
    }
    public void RecordResponse(string response){
        _responses.Add(response);
    }
}