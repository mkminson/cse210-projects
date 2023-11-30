using System;

public class Note
{
    private int _ptNum;
    private List<Activity> _activities = new List<Activity>();
    private string _activityType;
    private string _noteType;
    public Note(int ptNum, string noteType)
    {
        _ptNum = ptNum;
        _noteType = noteType;
    }
    public void DisplayMenu()
    {
        while (true)
        {
            if (_noteType.Equals("Rehab"))
            {
                Console.Write("The rehab activities are:\r\n    1. ADLs\r\n    2. IADLs\r\n    3. Therapeutic Exercise\r\n    4. Occupation\r\n    5. Finish adding activities\r\nWhat type of activity do you want to create: ");
                int menuChoice = int.Parse(Console.ReadLine());
                if (menuChoice == 1)
                {
                    Adls adl = new Adls();
                    _activityType = "ADL";
                    adl.SpecificActivity();
                    _activities.Add(adl);
                }
                else if (menuChoice == 2)
                {
                    Iadls iadl = new Iadls();
                    _activityType = "IADL";
                    iadl.SpecificActivity();
                    _activities.Add(iadl);
                }
                else if (menuChoice == 3)
                {
                    TherEx therEx = new TherEx();
                    _activityType = "Therapeutic Exercise";
                    therEx.SpecificActivity();
                    _activities.Add(therEx);
                }
                else if (menuChoice == 4)
                {
                    Occupations occupation = new Occupations();
                    _activityType = "Occupation";
                    occupation.SpecificActivity();
                    _activities.Add(occupation);
                }
                else if (menuChoice == 5)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Please enter an option 1-4.");
                }
            }
        }
    }
    public void ShowNoteInfo()
    {
        Console.WriteLine($"Note type : {_noteType}");
        if (_noteType == "Rehab")
        {
            Console.WriteLine($"Patient number : {_ptNum}");
        }
        else
        {
            Console.WriteLine($"Student number : {_ptNum}");
        }
        foreach (Activity act in _activities)
        {
            string info = act.DisplayInfo();
            Console.WriteLine(info);
        }
    }
    public void CreateActivity(string _activityType)
    {

    }
}