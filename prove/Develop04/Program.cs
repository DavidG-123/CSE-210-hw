using System;
using System.Collections.Generic;

class Program : Graphics
{
    static void Main(string[] args)
    {   
        void start() {
            int userIn = 0;
            MessageBoard(new List<int>{0});
            Thread.Sleep(2000);
            while(true) {
                Console.Clear();
                Console.Write($"Which mindfulness exercise do you want to do:\n    1. Breathing\n    2. Reflecting\n    3. Listing\n(enter a number)\n");
                string e = Console.ReadLine();
                try {
                    if (int.Parse(e) == 1 || int.Parse(e) == 2 || int.Parse(e) == 3) {
                        userIn = int.Parse(e);
                        break;
                    }
                    else {
                        Console.Clear();
                        Console.Write("That was not one of the options.");
                        Thread.Sleep(2000);
                    }
                }
                catch (Exception d) {
                    Console.Clear();
                    Console.Write("That was not one of the options.");
                    Thread.Sleep(2000);
                }
            }
            
            Breathing TakeBreaths = new Breathing();
            Reflection reflections = new Reflection();
            Listing lists = new Listing();
            if (userIn == 1){
                TakeBreaths.Breathe();
            }
            else if (userIn == 2) {
                reflections.Reflect();    
            }
            else{
                lists.ListThem();
            }
            start();
        }
        start();
    }
}