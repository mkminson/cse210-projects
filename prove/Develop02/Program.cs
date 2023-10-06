using System;
using System.ComponentModel.Design;
using System.Xml.Serialization;
using System.IO;

public class Program
{
    public static List<Entry> _entry = new();
    public static string _menueSelection = "";
    static void Main(string[] args)
    {
        int selection = 0;

        while(selection != 5)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices: \r\n1. Write \r\n2. Display\r\n" +
            "3. Load \r\n4. Save \r\n5. Quit");
            Console.Write("What would you like to do? ");
            _menueSelection = Console.ReadLine();
        //Exceeding requirements, I learned to use a try/catch block because the code throws an error
        // if a letter is selected. 
            try
            {
                selection = int.Parse(_menueSelection);
            }
            catch
            {
        
            }

            if(selection == 1)
            {
                AddAnEntry();
            }

            else if(selection == 2)
            {
                DisplayTheEntries();
            }
            else if(selection == 3)
            {
                LoadFromFile();
            }
            else if(selection == 4)
            {
                SaveToFile();
            }
            else if(selection == 5)
            {
                return;
            }
            //Exceeding requirements: This block prompts the user to enter a number 1-5 if a number other than 1-5, or 
            //a letter is selected. The try/catch statement keeps the program from throwing an error if a letter is entered.
            else
            {
                Console.WriteLine("Please only enter a number 1-5.");
            }
        }
    }

    public static void AddAnEntry()
    {
        Entry journalEntry = new();
        Console.WriteLine(journalEntry._prompt);
        Console.Write(">");
        string writing = Console.ReadLine();
        journalEntry._newEntry = writing;
        _entry.Add(journalEntry);
    }
    public static void DisplayTheEntries()
    {
        foreach(Entry e in _entry)
        {
            e.DisplayDatePromptEntry();
        }
    }
    public static void LoadFromFile()
    {
        Console.WriteLine("What is the file name:");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(":");
            Entry journalEntry = new();
            journalEntry._date = parts[0];
            journalEntry._prompt = parts[1];
            journalEntry._newEntry = parts[2];

            _entry.Add(journalEntry);
        }
    }
    public static void SaveToFile()
    {
        Console.WriteLine("What is the file name?");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(Entry e in _entry)
            {
                outputFile.WriteLine(e._date + ":"  + e._prompt + ":" + e._newEntry);
            }
        }
    }
}