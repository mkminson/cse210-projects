using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
    //     Reference ref1 = new Reference("Proverbs ", "3", "5", "6");

    //     Scripture s1 = new Scripture(ref1, "Trust in the Lord with all thine heart; and lean not unto thine own understanding." +
    //  " In all thy ways acknowledge him, and he shall direct thy paths.");
    //     s1.DisplayScripture();

        //Code to work with a scripture containing a single verse
        Reference ref2 = new Reference("John ", "3", "16");

        Scripture s2 = new Scripture(ref2, "For God so loved the world, that he gave his only begotton Son, that whosoever " +
        "believeth in him should not perish, but have everlasting life.");
        s2.DisplayShortScripture();

        Console.WriteLine("\r\n\r\nPress Enter to continue or type 'quit' to finish:");
        string answer = Console.ReadLine();

        while(answer != "quit")
        {
            if(answer == "quit")
            {
                return;
            }
            else if(answer == "")
            { //will include method call that subs random words for ___ until all words are replaced ie: GetRenderedText()
                Console.Clear();
                // s1.HideWords();
                // s1.DisplayScripture();
                s2.HideWords();
                s2.DisplayShortScripture();

                Console.WriteLine("\r\n\r\nPress Enter to continue or type 'quit' to finish:");
                answer = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please hit enter or type 'quit'.");
                answer = Console.ReadLine();
            }
            // if(s1.IsCompletelyHidden() == true)
            // {
            //     return;
            // }
            if(s2.IsCompletelyHidden() == true)
            {
                return;
            }
        }

    }
}