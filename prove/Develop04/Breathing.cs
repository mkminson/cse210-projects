using System;

public class Breathing : Activity
{
    public Breathing() : base()
    {

    }

    public void LetsBreathe()
    {
        string activityName = "Breathing";
        string activityDescription = "This activity will help you relax by walking you through breathing in and out slowly. " +
        "Clear your mind and focus on your breathing.";
        base.DisplayStartMessage(activityName, activityDescription);
        base.DisplayDurationPrompt();
        base.DisplayGetReady();
        DateTime endTime = DateTime.Now.AddSeconds(base.GetActivityDUration());
        while(DateTime.Now <= endTime)
        {
            OneBreath();
        }
        base.DisplayEndMessage();
    }

    public void OneBreath()
    {
        Console.Write("\r\n\r\nBreathe in...");
        base.CountDownTimer(4);
        Console.Write("\r\nNow breathe out...");
        base.CountDownTimer(6);
    }
}
