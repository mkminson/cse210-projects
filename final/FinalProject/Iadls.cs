using System;

class Iadls : Activity
{
    public Iadls()
    {

    }
    public override void SpecificActivity()
    {
        Console.Write("\r\nThe IADL activities include:\r\n    1. Food prep\r\n    2. Telephone communication\r\n    3. Writing\r\n    4. Computer use\r\n    5. Cleaning\r\n    6. Community Mobility\r\nWhich activity do you want to add to your note? ");
        int activityName = int.Parse(Console.ReadLine());
        if (activityName == 1)
        {
            _activityName = "Food Prep";
            Assistance();
            Breaks();
        }
        else if (activityName == 2)
        {
            _activityName = "Telephone communication";
            VerbalCues();
            Assistance();
        }
        else if (activityName == 3)
        {
            _activityName = "Writing";
            Handwriting();
            Assistance();
        }
        else if (activityName == 4)
        {
            _activityName = "Computer use";
            VerbalCues();
            Assistance();
        }
        else if (activityName == 5)
        {
            _activityName = "Cleaning";
            Assistance();
            Breaks();
        }
        else if (activityName == 6)
        {
            _activityName = "Community mobility";
            Assistance();
            Breaks();
        }
    }
    public override string DisplayInfo()
    {
        string activityInfo = "";
        if (_activityName == "Food Prep" || _activityName == "Cleaning" || _activityName == "Community mobility")
        {
            activityInfo = $"Activity name : {_activityName}; Assistance Level : {_assistLevel}; Breaks needed : {_breaksNeeded}";
            if (_breaksNeeded == true)
            {
                activityInfo += $"; Time before break needed : {_timeBeforeBreak}; Breaks taken : {_breaksTaken}";
            }
        }
        else if (_activityName == "Telephone communication" || _activityName == "Computer use")
        {
            activityInfo = $"Activity name : {_activityName}; Assistance Level : {_assistLevel}; Verbal cues : {_verbalCues}";
            if (_verbalCues == true)
            {
                activityInfo += $"; Number of cues required : {_numCues}";
            }
        }
        else if (_activityName == "Writing")
        {
            activityInfo = $"Activity name : {_activityName}; Assistance Level : {_assistLevel}; HOH Assist : {_hohAssist}";
            if (_hohAssist == true)
            {
                activityInfo += $"; Words requiring HOH Assist : {_hohAssistWords}; Ability to continue independently after HOH Assist : {_writeInd}";
            }
        }
        return activityInfo;
    }
}