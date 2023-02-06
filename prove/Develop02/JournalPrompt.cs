using System;

public class JournalPrompt {
    public string _Case1 = "What is/was something you want[ed] to do today?";
    public string _Case2 = "What did you eat for breakfast today?";
    public string _Case3 = "What friends did you [want to] see today?";
    public string _Case4 = "What is a message that you would write to your mom right now?";
    public string _Case5 = "How have you been feeling today?";
    public string _Case6 = "What is something that you would say about yourself right now for posterity?";
    public List<string> _Cases = new List<string>();
    public void AddtoList() {
        _Cases.Add(_Case1);
        _Cases.Add(_Case2);
        _Cases.Add(_Case3);
        _Cases.Add(_Case4);
        _Cases.Add(_Case5);
        _Cases.Add(_Case6);
    }
    public string[] UserPrompt(string ThePrompt) {
        Console.WriteLine(ThePrompt);
        string[] response = {Console.ReadLine().ToString(), ThePrompt};
        return response;
    }
}