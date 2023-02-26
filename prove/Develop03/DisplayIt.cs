using System;

public class DisplayIt {
    private string[] _percent = new string[5]{"100","75","45","25","0"};
    // private string _extraVerses;
    public void DisplayThat(string[] scriptures) {
        Console.WriteLine($"What percentage of the words of this verse do you want to see (select numerical value to the left)?\n1 - 100%\n2 - 75%\n3 - 45%\n4 - 25%\n5 - 0%\n");
        double percent = (Int16.Parse(_percent[Int16.Parse(Console.ReadLine()) - 1]) * .01);
        Console.Clear();

        List<int> countWords(string source, Char whattoFind) {
            int b = 0;
            List<int> wordIndex = new List<int>();
            foreach (var ch in source){
                if (ch == whattoFind) {
                    wordIndex.Add(b);
                }
                b++;
            }
            return(wordIndex);
        }

        List<int> wordInd = countWords(scriptures[2], '\x20');
        int words = wordInd.Count;
        if (percent == 0) {
            Console.Write($"{"    "} ({words + 1} words)\n\n\n\nPress enter when you are done with the passage :)");
            Console.ReadLine();
            Console.Clear();
        }
        else{
            void editedVerse(){


                int c = 0;
                List<string> wordlengths = new List<string>();
                foreach (var ch in wordInd) {
                    if (c==0) {
                        wordlengths.Add($"{ch}");

                        c++;
                    }
                    else {
                        wordlengths.Add($"{ch - wordInd[c-1]}");

                        c++;
                    }
                }
                string wordDrop = $"{(Math.Floor(percent * (words + 1)))}";

                List<int> dropWords(int wordstoDrop, int wordCap) {
                    int x = 0;
                    Random rnd = new Random(); 
                    List<int> lostWords = new List<int>();
                    while (true) {
                        if (x == wordstoDrop) {
                            break;
                        }
                        bool addInt = false;
                        if (x == 0) {
                            string newRandom = $"{rnd.Next(1, wordCap)}";
                            lostWords.Add(int.Parse(newRandom));
                            addInt = true;
                        }
                        else{
                        int d = 0;
                        while (true) {
                            string newRandom = $"{rnd.Next(1, wordCap)}";
                            if (int.Parse(newRandom) == lostWords[d]){
                                break;
                            }
                            d++;
                            if (d == x){
                                lostWords.Add(int.Parse(newRandom));
                                addInt = true;
                                break;
                            }
                        }
                        }

                        if (addInt == true) {
                            x++;
                        }
                    }
                    int b = 0;
                    List<int> sorteddropWords = new List<int>();
                    while (true) {
                        x = wordCap;
                        foreach (int in1 in lostWords) {
                            if (b == 0) {
                                if (in1 < x) {
                                    x = in1;
                                }
                            }
                            else {
                                if (in1 == sorteddropWords[b-1] || in1 < sorteddropWords[b-1]) {

                                }
                                else {
                                    if (in1 < x) {
                                        x = in1;
                                    }
                                }
                            }
                        }
                        sorteddropWords.Add(x);
                        b++;
                        if (b == lostWords.Count) {
                            break;
                        }
                    }
                    return sorteddropWords;
                }
                List<int> droptheWords;
                List<List<int>> ranges;

                droptheWords = dropWords(int.Parse(wordDrop), words + 1);
                int b = 0;
                ranges = new List<List<int>>();
                foreach (string in1 in wordlengths) {
                    if (b == 0) {
                        ranges.Add(new List<int>(){1, int.Parse(wordlengths[b])+1});
                    }
                    else {
                        ranges.Add(new List<int>(){ranges[b-1][1] + 1, ranges[b-1][1] + int.Parse(wordlengths[b])});
                    }
                    b++;
                }
                ranges.Add(new List<int>(){ranges[b-1][1], scriptures[2].Length});
                string verse = "";
                if (double.Parse($"{percent}") == 1 || double.Parse($"{percent}") == 0) {
                    if (double.Parse($"{percent}") == 1) {
                        verse = scriptures[2];
                    }
                    if (double.Parse($"{percent}") == 0) {
                        verse = "    ";
                    } 
                }
                else {
                    c = 1;
                    b = 0;
                    verse = "";
                    foreach (var ch in scriptures[2]) {
                        if (c >= ranges[b][0] && c <= ranges[b][1]) {
                        }
                        else {
                            b++;
                        }
                        int a = 0;
                        bool isDel = false;
                        while (true) {
                            if (ranges[b][0] == ranges[droptheWords[a]-1][0]) {
                                break;
                            }
                            a++;
                            if (a==droptheWords.Count) {
                                isDel = true;
                                break;
                            }
                        }
                        if (isDel == true) {
                            verse += " ";
                        }
                        else {
                            verse += ch;
                        }
                        c++;
                    }
                }
                Console.Write($"{verse} ({words + 1} words)\n\n\n\nPress enter when you are done with the passage :)");
                Console.ReadLine();
                Console.Clear();
            }
            editedVerse();
        }
    }
}