using System;

class Program
{
    private static List<Note> _notes = new List<Note>();
    static void Main(string[] args)
    {
        Console.Clear();
        while (true)
        {
            Console.Write("Your options are as follows:\r\n    1. Create a note\r\n    2. Save note(s) to a file\r\n    3. Load note(s) from a file\r\n    4. Display note(s)\r\n    5. Quit\r\nWhat would you like to do? ");
            int selection = int.Parse(Console.ReadLine());
            if (selection == 1)
            {
                Console.Write("\r\nThe note types are:\r\n    1. Rehab note\r\n    2. School note\r\nWhich type of note would you like to create? ");
                int selection2 = int.Parse(Console.ReadLine());
                string noteType;
                int ptNum;
                if (selection2 == 1)
                {
                    noteType = "Rehab";
                    Console.Write("\r\nWhat is the patient number? ");
                    ptNum = int.Parse(Console.ReadLine());
                }
                else
                {
                    noteType = "School";
                    Console.Write("\r\nWhat is the student number: ");
                    ptNum = int.Parse(Console.ReadLine());
                }
                Note note = new Note(ptNum, noteType, false);
                note.DisplayMenu();
                _notes.Add(note);
            }
            else if (selection == 2)
            {
                SaveToFile();
            }
            else if (selection == 3)
            {
                LoadFromFile();
            }
            else if (selection == 4)
            {
                foreach (Note note in _notes)
                {
                    note.ShowNoteInfo();
                }
            }
            else if (selection == 5)
            {
                return;
            }
            else
            {
                Console.WriteLine("\r\nPlease select a number 1-5.");
            }
        }
    }
    public static void SaveToFile()
    {
        Console.Write("\r\nWhat is the file name for the note file? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Note n in _notes)
            {
                outputFile.WriteLine(n.GetNoteType());
                outputFile.WriteLine(n.GetPtNum());
                if (n.GetLoadedNote())
                {
                    List<string> loadedActivities = n.GetLoadedActivities();
                    foreach (string a in loadedActivities)
                    {
                        outputFile.WriteLine(a);
                    }
                }
                else
                {
                    List<Activity> noteActivities = n.GetActivities();
                    foreach (Activity a in noteActivities)
                    {
                        outputFile.WriteLine(a.DisplayInfo());
                    }
                    outputFile.WriteLine("-*-*-End of note-*-*-");
                }
            }
        }
    }
    public static void LoadFromFile()
    {
        _notes.Clear();
        Console.Write("\r\nWhat is the file name for the note file: ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        for (int i = 0; i < lines.Length; i++)
        {
            string noteType = lines[i];
            i++;
            int ptNum = int.Parse(lines[i]);
            Note note1 = new Note(ptNum, noteType, true);
            i++;
            while (!lines[i].Equals("-*-*-End of note-*-*-"))
            {
                note1.SetLoadedActivities(lines[i]);
                i++;
            }
            _notes.Add(note1);
        }
    }
}