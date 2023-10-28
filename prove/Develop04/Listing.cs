using System;
using System.Runtime.CompilerServices;

public class Listing : Activity
{
    private List<string> _listPrompts = new()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    public Listing() : base()
    {

    }

    public void LetsList()
    {
        string activityName = "Listing";
        string activityDescription = "This activity will help you reflect on the good things in your life by having you list " +
        "as many things as you can in a certian area.";
        base.DisplayStartMessage(activityName, activityDescription);
        base.DisplayDurationPrompt();
        base.DisplayGetReady();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        DisplayListPrompt();
        Console.Write("You may begin in: ");
        base.CountDownTimer(5);
        int responses = 0;
        DateTime endTime = DateTime.Now.AddSeconds(base.GetActivityDUration());
        Console.WriteLine(" ");
        while (DateTime.Now <= endTime)
        {
            Console.Write(">");
            Console.ReadLine();
            responses++;
        }
        Console.WriteLine($"You listed {responses} items!");
        base.DisplayEndMessage();
    }

    public void DisplayListPrompt()
    {
        Random rand = new Random();
        int randIndex = rand.Next(_listPrompts.Count);
        Console.WriteLine($"\r\n---{_listPrompts[randIndex]}---");
    }
}