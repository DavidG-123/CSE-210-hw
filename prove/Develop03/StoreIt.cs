using System;

public class StoreIt {
    private string _book;
    private string _reference;
    private string _text;
    LdsScriptures readScript = new LdsScriptures();

    public string[] writeThat(string[] scriptures) {
        List<string[]> fullScript = readScript.addVerses();
        int a = 0;
        while (a < 6604) {
            if (fullScript[a][0] == scriptures[0]) {
                if (Int16.Parse(fullScript[a][1]) == Int16.Parse(scriptures[1])) {
                    if (Int16.Parse(fullScript[a][2]) == Int16.Parse(scriptures[2])) {
                        _book = fullScript[a][0];
                        _reference = $"{Int16.Parse(scriptures[1])}:{Int16.Parse(scriptures[2])}";
                        _text = fullScript[a][3];
                        return(new string[3]{_book, _reference, _text});
                    }
                }
            }
            a += 1;
        }
        return(new string[2]{"Error: ", "Scripture does not exist."});
    }
}