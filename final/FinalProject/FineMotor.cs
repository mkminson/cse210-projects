using System;

class FineMotor : Activity
{
    private string _lineAdhere;
    private string _letterSize;
    private string _letterFormation;
    private string _legibility;
    private string _distFromLine;
    private string _distPercent;
    private string _otherName;
    public FineMotor()
    {

    }
    public override void SpecificActivity()
    {
        Console.Write("\r\nThe Fine Motor activities include:\r\n    1. Handwriting\r\n    2. Scissor use\r\n    3. Other\r\nWhich activity do you want to add to your note? ");
        int activityName = int.Parse(Console.ReadLine());
        if (activityName == 1)
        {
            _activityName = "Handwriting";
            Handwriting();
            Console.Write("\r\nWhat was the student's line adherence (good, fair, poor)? ");
            _lineAdhere = Console.ReadLine();
            Console.Write("Was the student's letter size good, large or small? ");
            _letterSize = Console.ReadLine();
            Console.Write("How was the student's letter formation (good, fair, poor)? ");
            _letterFormation = Console.ReadLine();
            Console.Write("What percentage of legibility did the student demonstrate? ");
            _legibility = Console.ReadLine();
        }
        else if (activityName == 2)
        {
            _activityName = "Scissor use";
            Assistance();
            Console.Write("\r\nHow close to the line was the student able to cut (enter a fraction of an inch)? ");
            _distFromLine = Console.ReadLine();
            Console.Write("What percent of the time was the student able to maintain this distance? ");
            _distPercent = Console.ReadLine();
        }
        else if (activityName == 3)
        {
            _activityName = "Other";
            Console.Write("\r\nWhat was the activity (choose anything a child might do at school)? ");
            _otherName = Console.ReadLine();
            Assistance();
            VerbalCues();
            Console.Write("What were the student's strengths in this activity? ");
            _strengths = Console.ReadLine();
            Console.Write("What were the student's struggles in this activity? ");
            _struggles = Console.ReadLine();
        }
    }
    public override string DisplayInfo()
    {
        string activityInfo = "";
        if (_activityName == "Handwriting")
        {
            activityInfo = $"Activity name : {_activityName}; HOH Assist : {_hohAssist}";
            if (_hohAssist == true)
            {
                activityInfo += $"; Words requiring HOH Assist : {_hohAssistWords}; Ability to continue independently after HOH Assist : {_writeInd}";
            }
            activityInfo += $"; Line adherence : {_lineAdhere}; Letter size : {_letterSize}; Letter formation : {_letterFormation}; Legibility : {_legibility}";
        }
        if (_activityName == "Scissor use")
        {
            activityInfo = $"Activity name : {_activityName}; Assistance Level : {_assistLevel}; Distance from line : {_distFromLine}; Percent of time at that distance : {_distPercent}";
        }
        if (_activityName == "Other")
        {
            activityInfo = $"Activity name : {_otherName}; Assistance Level : {_assistLevel}; Verbal cues : {_verbalCues}";
            if (_verbalCues == true)
            {
                activityInfo += $"; Number of cues required : {_numCues}";
            }
            activityInfo += $"; Strengths : {_strengths}; Struggles : {_struggles}";
        }
        return activityInfo;
    }
}