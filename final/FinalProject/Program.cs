using System;

class Program
{
    private static List<Note> _notes = new List<Note>();
    static void Main(string[] args)
    {
        Console.Clear();
        while (true)
        {
            Console.Write("Your options are as follows:\r\n    1. Create a note\r\n    2. Save note\r\n    3. Load note\r\n    4. Display note\r\n    5. Quit\r\nWhat would you like to do? ");
            int selection = int.Parse(Console.ReadLine());
            if (selection == 1)
            {
                Console.Write("The options are:\r\n    1. Rehab note\r\n    2. School note\r\nWhich type of note would you like to create? ");
                int selection2 = int.Parse(Console.ReadLine());
                string noteType;
                int ptNum;
                if (selection2 == 1)
                {
                    noteType = "Rehab";
                    Console.Write("What is the patient number? ");
                    ptNum = int.Parse(Console.ReadLine());
                }
                else
                {
                    noteType = "School";
                    Console.Write("What is the student number: ");
                    ptNum = int.Parse(Console.ReadLine());
                }
                Note note = new Note(ptNum, noteType);
                note.DisplayMenu();
                _notes.Add(note);
            }
            else if (selection == 2)
            {

            }
            else if (selection == 3)
            {

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
                Console.WriteLine("Please select a number 1-5.");
            }
        }
    }
}