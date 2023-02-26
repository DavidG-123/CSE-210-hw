using System;

public class DisplayIt {
    private string[] _percent = new string[5]{"100","75","45","25","0"};
    private string _extraVerses;
    public void DisplayThat(string[] scriptures) {
        Console.WriteLine($"What percentage of the words of this verse do you want to see (select numerical value to the left)?\n1 - 100%\n2 - 75%\n3 - 45%\n4 - 25%\n5 - 0%\n");
        double percent = (Int16.Parse(_percent[Int16.Parse(Console.ReadLine()) - 1]) * .01);
        Console.WriteLine($"{scriptures[2]} {scriptures[2].Length}");

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
        int words = wordInd.Count + 1;
        Console.WriteLine();
        void editedVerse(){
            int c = 0;
            List<string> wordlengths = new List<string>();
            foreach (var ch in wordInd) {
                if (c==0) {
                    wordlengths.Add($"{ch}");
                    Console.WriteLine($"{ch} {c}");
                    c++;
                }
                else {
                    wordlengths.Add($"{ch - wordInd[c-1]}");
                    Console.WriteLine($"{ch - wordInd[c-1]} {c}");
                    c++;
                }
            }
            wordlengths.Add($"{wordInd[words-1]}");
        }
        editedVerse();
    }
}