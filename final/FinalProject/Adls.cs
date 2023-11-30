using System;

public class Adls : Activity
{
    public Adls()
    {

    }
    public override void SpecificActivity()
    {
        Console.Write("The ADL activities include:\r\n    1. Functional mobility\r\n    2. Toileting\r\n    3. Grooming\r\n    4. Dressing\r\nWhich activity do you want to add to your note? ");
        int activityName = int.Parse(Console.ReadLine());
        if (activityName == 1)
        {
            _activityName = "Functional mobility";
            Assistance();
            Breaks();
        }
        else if (activityName == 2)
        {
            _activityName = "Toileting";
            Assistance();
        }
        else if (activityName == 3)
        {
            _activityName = "Grooming";
            Assistance();
            Breaks();
        }
        else if (activityName == 4)
        {
            _activityName = "Dressing";
            Assistance();
            Breaks();
        }
    }
    public override string DisplayInfo()
    {
        string activityInfo = $"Activity name : {_activityName}, Assistance Level : {_assistLevel}, Breaks needed : {_breaksNeeded}";
        if (_breaksNeeded == true)
        {
            activityInfo += $", Time before break needed : {_timeBeforeBreak}, Breaks taken : {_breaksTaken}";
        }
        return activityInfo;
    }
}