using System;

public abstract class Activity
{
    protected string _activityName = "";
    protected string _strengths;
    protected string _struggles;
    protected bool _breaksNeeded;
    protected int _breaksTaken;
    protected string _timeBeforeBreak;
    protected string _assistLevel;
    protected bool _hohAssist;
    protected string _hohAssistWords;
    protected bool _verbalCues;
    protected string _numCues;
    protected string _writeInd;
    public Activity()
    {

    }
    public abstract void SpecificActivity();
    public abstract string DisplayInfo();
    public void Assistance()
    {
        Console.Write("\r\nWhat was their assist level required (Most common options include: dependent, 75%, 50%, 25%, stand by, supervision, or independent)? ");
        _assistLevel = Console.ReadLine();
    }
    public void Breaks()
    {
        string breaks = "";
        while (breaks != "y" && breaks != "n")
        {
            Console.Write("\r\nDid the patient require any rest breaks during this activity (y/n)? ");
            breaks = Console.ReadLine();
            if (breaks == "y")
            {
                _breaksNeeded = true;
                Console.Write("\r\nHow long were they able to participate before needing a break? ");
                _timeBeforeBreak = Console.ReadLine();
                Console.Write("\r\nHow many breaks did they take while working on this activity? ");
                _breaksTaken = int.Parse(Console.ReadLine());
            }
            else if (breaks == "n")
            {
                _breaksNeeded = false;
            }
            else
            {
                Console.WriteLine("Please only enter y or n");
            }
        }
    }
    public void Handwriting()
    {
        Console.Write("\r\nWas hand over hand (HOH- where the therapist directly guides the writing with their hand over the client's hand) assist required (y/n)? ");
        string hoh = Console.ReadLine();
        if (hoh == "y")
        {
            _hohAssist = true;
            Console.Write("\r\nHow many words rquired HOH Assist? ");
            _hohAssistWords = Console.ReadLine();
            Console.Write("\r\nWere they able to continue writing independantly after having HOH Assist (yes or no)? ");
            _writeInd = Console.ReadLine();
        }
        else
        {
            _hohAssist = false;
        }
    }
    public void VerbalCues()
    {
        string cues = "";
        while (cues != "y" && cues != "n")
        {
            Console.Write("\r\nWere verbal cues required (y/n)? ");
            cues = Console.ReadLine();
            if (cues == "y")
            {
                _verbalCues = true;
                Console.Write("\r\nHow many verbal cues were required for them to complete the activity? ");
                _numCues = Console.ReadLine();
            }
            else if (cues == "n")
            {
                _verbalCues = false;
            }
            else
            {
                Console.WriteLine("Please only enter y or n");
            }
        }
    }
}