using System;

public class Activity
{
    protected string _activityName = "";
    protected int _oppGiven;
    protected int _oppSuccess;
    protected int _accuracy;
    protected string _coordination;
    protected string _strengths;
    protected string _struggles;
    protected bool _breaksNeeded;
    protected int _breaksTaken;
    protected string _timeBeforeBreak;
    protected string _assistLevel;
    public Activity()
    {

    }
    public virtual void SpecificActivity()
    {

    }
    public virtual string DisplayInfo()
    {
        return "";
    }
    public void Assistance()
    {
        Console.Write("What was the patient's assist level required? ");
        _assistLevel = Console.ReadLine();
    }
    public void Breaks()
    {
        Console.Write("Did the patient require any rest breaks during this activity (y/n)? ");
        string breaks = Console.ReadLine();
        if (breaks == "y")
        {
            _breaksNeeded = true;
            Console.Write("How long were they able to participate before needing a break? ");
            _timeBeforeBreak = Console.ReadLine();
            Console.Write("How many breaks did they take while working on this activity? ");
            _breaksTaken = int.Parse(Console.ReadLine());
        }
        else
        {
            _breaksNeeded = false;
        }
    }
}