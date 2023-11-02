using System;

public class Activity
{
    private string _activityName = "";
    private string _activityDescription = "";
    private int _activityDuration;
    private List<string> _animation = new List<string>() { "|", "/", "-", "\\", "|", "/", "-", "\\" };

    public Activity()
    {

    }

    public void DisplayStartMessage(string activityName, string activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
        Console.WriteLine($"Welcome to the {_activityName} Activity.\r\n");
        Console.WriteLine(_activityDescription + "\r\n");
    }

    public void DisplayDurationPrompt()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _activityDuration = int.Parse(Console.ReadLine());
    }

    public int GetActivityDUration()
    {
        return _activityDuration;
    }
    public void DisplayGetReady()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        PauseAnimation(5);
    }

    public void PauseAnimation(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string a = _animation[i];
            Console.Write(a);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            if (i >= _animation.Count)
            {
                i = 0;
            }
        }
    }

    public void CountDownTimer(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("\r\n\r\nWell done!!");
        PauseAnimation(5);
        Console.WriteLine($"You have completed another {_activityDuration} seconds of the {_activityName} Activity.");
        PauseAnimation(5);
    }
}