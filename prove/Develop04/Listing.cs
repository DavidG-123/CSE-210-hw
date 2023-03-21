using System;
using System.Collections.Generic;

public class Listing : Graphics {
    public void ListThem() {
        void UserStart() {
            MessageBoard(new List<int>{10});
            Waiting();
            MessageBoard(new List<int>{11});
            Waiting();
            Loading();
            ListThis();
            MessageBoard(new List<int>{12});

        }
        void UserNext() {

        }
    UserStart();
    }
}