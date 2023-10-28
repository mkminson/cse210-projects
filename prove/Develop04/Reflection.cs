using System;

public class Reflection : Activity
{
    private List<string> _prompts = new()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

    private List<string> _questions = new()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    public Reflection() : base()
    {

    }

    public void LetsReflect()
    {
        string activityName = "Reflecting";
        string activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. " +
        "This will help you recognize the power you have and how you can use it in other aspects of your life.";
        base.DisplayStartMessage(activityName, activityDescription);
        base.DisplayDurationPrompt();
        base.DisplayGetReady();
        DisplayPrompt();
        Console.WriteLine("\r\nNow ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine("You may begin in: ");
        base.CountDownTimer(5);
        Console.Clear();
        DateTime endTime = DateTime.Now.AddSeconds(base.GetActivityDUration());
        while (DateTime.Now <= endTime)
        {
            DisplayQuestion();
        }
        base.DisplayEndMessage();
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("\r\nConsider the following prompt:");


        Random ran = new Random();
        int randomIndex = ran.Next(_prompts.Count);
        Console.WriteLine($"\r\n---{_prompts[randomIndex]}---");
        Console.WriteLine("\r\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    public void DisplayQuestion()
    {
        Random rand = new Random();
        int randIndex = rand.Next(_questions.Count);
        Console.Write($"\r\n>{_questions[randIndex]}");
        base.PauseAnimation(10);
    }
}