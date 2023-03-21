using System;
using System.Collections.Generic;

public class Reflection : Graphics {
    public void Reflect() {
        void UserStart() {
            MessageBoard(new List<int>{3,4,5});
            Loading();
            MessageBoard(new List<int>{6});
            Waiting();
            MessageBoard(new List<int>{7});
            Waiting();
            MessageBoard(new List<int>{8});
            Waiting();
            MessageBoard(new List<int>{9});
            Waiting();
            MessageBoard(new List<int>{14});
            Thread.Sleep(3000);
        }
        UserStart();
    }
}