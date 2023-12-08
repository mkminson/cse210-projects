using System;

public class Note
{
    private int _ptNum;
    private List<Activity> _activities = new List<Activity>();
    private string _activityType;
    private string _noteType;
    private bool _loadedNote;
    private List<string> _loadedActivities = new List<string>();
    public Note(int ptNum, string noteType, bool loadedNote)
    {
        _ptNum = ptNum;
        _noteType = noteType;
        _loadedNote = loadedNote;
    }
    public string GetNoteType()
    {
        return _noteType;
    }
    public int GetPtNum()
    {
        return _ptNum;
    }
    public bool GetLoadedNote()
    {
        return _loadedNote;
    }
    public List<string> GetLoadedActivities()
    {
        return _loadedActivities;
    }
    public void SetLoadedActivities(string activity)
    {
        _loadedActivities.Add(activity);
    }
    public List<Activity> GetActivities()
    {
        return _activities;
    }
    public void DisplayMenu()
    {
        while (true)
        {
            if (_noteType.Equals("Rehab"))
            {
                Console.Write("\r\nThe rehab activities are:\r\n    1. ADLs (Activities of Daily Living)\r\n    2. IADLs (Instrumentatl Activities of Daily Living)\r\n    3. Therapeutic Exercise\r\n    4. Occupation\r\n    5. Finish adding activities\r\nWhat type of activity do you want to create? ");
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
                    Console.WriteLine("\r\nPlease enter an option 1-5.");
                }
            }
            if (_noteType.Equals("School"))
            {
                Console.Write("\r\nThe school activities are:\r\n    1. Fine Motor\r\n    2. Gross Motor\r\n    3. Finish adding activities\r\nWhat type of activity do you want to create? ");
                int menuChoice = int.Parse(Console.ReadLine());
                if (menuChoice == 1)
                {
                    FineMotor fineMotor = new FineMotor();
                    _activityType = "Fine Motor";
                    fineMotor.SpecificActivity();
                    _activities.Add(fineMotor);
                }
                else if (menuChoice == 2)
                {
                    GrossMotor grossMotor = new GrossMotor();
                    _activityType = "Gross Motor";
                    grossMotor.SpecificActivity();
                    _activities.Add(grossMotor);
                }
                else if (menuChoice == 3)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("\r\nPlease enter an option 1-3.");
                }
            }
        }
    }
    public void ShowNoteInfo()
    {
        Console.WriteLine($"\r\nNote type : {_noteType}");
        if (_noteType == "Rehab")
        {
            Console.WriteLine($"Patient number : {_ptNum}");
        }
        else
        {
            Console.WriteLine($"Student number : {_ptNum}");
        }
        if (_loadedNote == false)
        {
            foreach (Activity act in _activities)
            {
                string info = act.DisplayInfo();
                Console.WriteLine(info);
            }
        }
        else
        {
            foreach (string a in _loadedActivities)
            {
                Console.WriteLine(a);
            }
        }
    }
}
