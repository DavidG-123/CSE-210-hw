using System;

class Program
{
    static void Main(string[] args)
    {   
        string[] space = new string[17] {" ", "  ", "   ", "    ", "     ", "      ", "       ", "        ", "         ", "          ", "           ", "            ", "             ", "              ", "               ", "                ", "                 "};
        string[] catalog = new string[15] {"first_Nephi","second_Nephi","Jacob","Enos","Jarom","Omni","Words_of_Mormon","Mosiah","Alma","Helaman","third_Nephi","fourth_Nephi","Mormon","Ether","Moroni"};
        Console.WriteLine("Wlecome to Scripture Memorizer!");

        StoreIt scriptWrite = new StoreIt();
        DisplayIt displayThis = new DisplayIt();

        void scriptures() {
            Console.WriteLine($"1 - {catalog[0]}{space[0]}2 - {catalog[1]}{space[2]}3 - {catalog[2]}{space[11]}4 - {catalog[3]}\n5 - {catalog[4]}{space[10]}6 - {catalog[5]}{space[3]}7 - {catalog[6]}{space[2]}8 - {catalog[7]}\n9 - {catalog[8]}{space[6]}10 - {catalog[9]}{space[1]}11 - {catalog[10]}{space[1]}12 - {catalog[11]}\n13 - {catalog[12]}{space[15]}14 - {catalog[13]}{space[15]}15 - {catalog[14]}");
            string[] books = new string[15]{"1-ne","2-ne","jacob","enos","jarom","omni","w-of-m","mosiah","alma","hel","3-ne","4-ne","morm","ether","moro"};

            Console.Write("Please select the numeric value of the book that you want:\n");
            string book = books[Int16.Parse(Console.ReadLine()) - 1];

            Console.Write("What chapter do you want?\n");
            string chapter = Console.ReadLine();

            Console.Write("What verse do you want?\n");
            string verse = Console.ReadLine();
            
            string[] assembledVerse = scriptWrite.writeThat(new string[3]{book, chapter, verse});

            if (assembledVerse[0] != "Error: ") {
                displayThis.DisplayThat(assembledVerse);
            }
            else {
                Console.WriteLine($"{assembledVerse[0]}{assembledVerse[1]}");
            }
            scriptures();
        }
        scriptures();
    }
}