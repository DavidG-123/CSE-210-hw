using System;
using System.Collections.Generic;

public class Breathing : Graphics {
    public void Breathe() {
        void UserStart() {
            MessageBoard(new List<int>{0,1});
            Console.Write("(press 'enter' to continue)");Console.ReadLine();
            
            base.triangleAnimation();
            base.triangleAnimation();
            UserNext();
        }
        void UserNext() {
            Reflection reflections = new Reflection();
            reflections.Reflect();
        }

        UserStart();
    }
}