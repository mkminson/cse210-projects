using System;

class Occupations : Activity
{
    private string _occupationName;
    public Occupations()
    {

    }
    public override void SpecificActivity()
    {
        Console.Write("\r\nWhat occupation did they perform (occupations are anything that is meaningful to the client: hobbies, work, etc)? ");
        _occupationName = Console.ReadLine();
        Assistance();
        VerbalCues();
        Breaks();
    }
    public override string DisplayInfo()
    {
        string activityInfo = "";
        _activityName = "Occupation";
        activityInfo = $"Activity name : {_activityName}; {_occupationName}; Assistance Level : {_assistLevel}; Verbal cues : {_verbalCues}";
        if (_verbalCues == true)
        {
            activityInfo += $"; Number of cues reaquired : {_numCues}";
        }
        activityInfo += $"; Breaks needed : {_breaksNeeded}";
        if (_breaksNeeded == true)
        {
            activityInfo += $"; Time before break needed : {_timeBeforeBreak}; Breaks taken : {_breaksTaken}";
        }
        return activityInfo;
    }
}