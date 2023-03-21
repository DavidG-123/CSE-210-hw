using System;
using System.Collections.Generic;

public class Listing : Graphics {
    public void ListThem() {
        void UserStart() {
            MessageBoard(new List<int>{13});
            Thread.Sleep(2500);
            MessageBoard(new List<int>{10});
            Thread.Sleep(2500);
            MessageBoard(new List<int>{11});
            Loading();
            ListThis();
            MessageBoard(new List<int>{14});
            Thread.Sleep(3000);
        }
    UserStart();
    }
}