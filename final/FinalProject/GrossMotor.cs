using System;

class GrossMotor : Activity
{
    private string _oppGiven;
    private string _oppSuccess;
    private string _coordination;
    private string _walks;
    private string _otherActivity;
    public GrossMotor()
    {

    }
    public override void SpecificActivity()
    {
        Console.Write("\r\nThe Fine Motor activities include:\r\n    1. Bounce and catch a ball\r\n    2. Animal walks\r\n    3. Other\r\nWhich activity do you want to add to your note? ");
        int activityName = int.Parse(Console.ReadLine());
        if (activityName == 1)
        {
            _activityName = "Bounce and catch a ball";
            Console.Write("\r\nHow many times did they bounce the ball? ");
            _oppGiven = Console.ReadLine();
            Console.Write("How many times did they catch it? ");
            _oppSuccess = Console.ReadLine();
            Console.Write("Did they catch it with good, fair or poor coordination? ");
            _coordination = Console.ReadLine();
        }
        else if (activityName == 2)
        {
            _activityName = "Animal walks";
            Console.Write("\r\nWhich animal walks did they do? ");
            _walks = Console.ReadLine();
            Console.Write("How was the student's coordination with these walks (good, fair, poor)? ");
            _coordination = Console.ReadLine();
        }
        else if (activityName == 3)
        {
            _activityName = "Other";
            Console.Write("\r\nWhat was the activity (anything using large muscles that a child could do at school)? ");
            _otherActivity = Console.ReadLine();
            Assistance();
            VerbalCues();
            Console.Write("What were the student's strengths in this activity? ");
            _strengths = Console.ReadLine();
            Console.Write("What were the student's struggles in this activity? ");
            _struggles = Console.ReadLine();
            Console.Write("How was the student's coordination with this activity (good, fair, poor)? ");
            _coordination = Console.ReadLine();
        }
    }
    public override string DisplayInfo()
    {
        string activityInfo = "";
        if (_activityName == "Bounce and catch a ball")
        {
            activityInfo = $"Activity name : {_activityName}; Opportunities given to catch the ball : {_oppGiven}; Number of times successfully caught ball : {_oppSuccess}; Student's coordination : {_coordination}";
        }
        if (_activityName == "Animal walks")
        {
            activityInfo = $"Activity name : {_activityName}; Walks done : {_walks}; Student's coordination : {_coordination}";
        }
        if (_activityName == "Other")
        {
            activityInfo = $"Activity name : {_otherActivity}; Assistance Level : {_assistLevel}; Verbal cues : {_verbalCues}";
            if (_verbalCues == true)
            {
                activityInfo += $"; Number of cues required : {_numCues}";
            }
            activityInfo += $"; Strengths : {_strengths}; Struggles : {_struggles}; Coordination : {_coordination}";
        }
        return activityInfo;
    }
}