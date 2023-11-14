using System;
using System.Runtime.CompilerServices;

class Program
{
    public static int totalPoints = 0;
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();

        int selection1 = 0;

        while (true)
        {
            Console.WriteLine($"\r\nYou have {totalPoints} points.\r\n");
            Console.WriteLine("Menu options:\r\n    1. Create New Goal\r\n    2. List Goals\r\n    3. Save Goals\r\n    4. Load Goals\r\n" +
            "    5. Record Event\r\n    6. Quit");
            Console.Write("Select a choice from the menu: ");

            selection1 = int.Parse(Console.ReadLine());

            if (selection1 == 1)
            {
                goals = CreateNewGoal(goals);
            }
            else if (selection1 == 2)
            {
                Console.WriteLine("The goals are:");
                int i = 1;
                foreach (Goal type in goals)
                {
                    Console.Write($"{i}. ");
                    type.DisplayGoal();
                    i++;
                }
            }
            else if (selection1 == 3)
            {
                SaveToFile(goals, totalPoints);
            }
            else if (selection1 == 4)
            {
                LoadFromFile(goals);
            }
            else if (selection1 == 5)
            {
                UpdateGoal(goals);
            }
            else
            {
                return;
            }
        }
    }
    public static List<Goal> CreateNewGoal(List<Goal> goals)
    {
        Console.Write("The types of goals are:\r\n    1. Simple Goal\r\n    2. Eternal Goal\r\n    3. Checklist Goal\r\nWhich type of goal would you like to create? ");
        int selection2 = 0;
        selection2 = int.Parse(Console.ReadLine());
        if (selection2 == 1)
        {
            Simple simple = new Simple();
            simple.SetGoalAttributes();
            goals.Add(simple);
        }
        else if (selection2 == 2)
        {
            Eternal eternal = new Eternal();
            eternal.SetGoalAttributes();
            goals.Add(eternal);
        }
        else if (selection2 == 3)
        {
            Checklist checklist = new Checklist();
            checklist.SetGoalAttributes();
            goals.Add(checklist);
        }
        return goals;
    }

    public static void SaveToFile(List<Goal> goals, int totalPoints)
    {
        Console.Write("What is the file name for the goal file? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(totalPoints);
            foreach (Goal g in goals)
            {
                outputFile.WriteLine(g.SaveFileString());
            }
        }
    }
    public static void LoadFromFile(List<Goal> goals)
    {
        goals.Clear();
        Console.Write("What is the file name for the goal file: ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        totalPoints = int.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            if (parts[0].Equals("SimpleGoal"))
            {
                Simple simple = new Simple(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                goals.Add(simple);
            }
            else if (parts[0].Equals("EternalGoal"))
            {
                Eternal eternal = new Eternal(parts[1], parts[2], int.Parse(parts[3]));
                goals.Add(eternal);
            }
            else if (parts[0].Equals("ChecklistGoal"))
            {
                Checklist checklist = new Checklist(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                goals.Add(checklist);
            }
        }
    }
    public static List<Goal> UpdateGoal(List<Goal> goals)
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + goals[i].GetName());
        }
        Console.Write($"Which goal did you accomplish? ");
        int goalChoice = int.Parse(Console.ReadLine());
        totalPoints += goals[goalChoice - 1].RecordEvent();
        Console.WriteLine($"You now have {totalPoints} points.");
        return goals;
    }
}