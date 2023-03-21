using System;
using System.Collections.Generic;

public class Reflection : Graphics {
    public void Reflect() {
        void UserStart() {
            MessageBoard(new List<int>{2,3,4,5});
            Loading();
            MessageBoard(new List<int>{6});
            Waiting();
            MessageBoard(new List<int>{7});
            Waiting();
            MessageBoard(new List<int>{8});
            Waiting();
            MessageBoard(new List<int>{9});
            Waiting();
            UserNext();
        }
        void UserNext() {
            Listing lists = new Listing();
            lists.ListThem();
        }
        UserStart();
    }
}