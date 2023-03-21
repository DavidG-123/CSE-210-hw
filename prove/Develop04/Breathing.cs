using System;
using System.Collections.Generic;

public class Breathing : Graphics {
    public void Breathe() {
        void UserStart() {
            MessageBoard(new List<int>{1});
            Console.Write("(press 'enter' to continue)");Console.ReadLine();
            
            base.triangleAnimation();
            base.triangleAnimation();
            MessageBoard(new List<int>{14});
            Thread.Sleep(3000);
        }
        UserStart();
    }
}