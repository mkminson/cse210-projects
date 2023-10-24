using System;

public class Activity
{
    private string _activityName = "";
    private string _activityDescription = "";
    private int _activityDuration;
    private string _finishingMessage = "";
    private List<string> _animation = new List<string>(){"|", "/", "-", "\\", "|", "/", "-", "\\"};

    public Activity()
    {

    }
   
    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine(_activityDescription);
    }

    public void DisplayDurationPrompt()
    {
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        _activityDuration = int.Parse(Console.ReadLine());
    }

    public void PauseAnimation()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string a = _animation[i];
            Console.Write(a);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            if(i >= _animation.Count)
            {
                i = 0;
            }
        }
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("Well done!!");
        PauseAnimation();
        Console.WriteLine($"You have completed another {_activityDuration} seconds of the {_activityName} activity");
        PauseAnimation();
    }
}