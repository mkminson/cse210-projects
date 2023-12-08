using System;

class TherEx : Activity
{
    private int _sets;
    private int _reps;
    private int _weight;
    private float _time;
    private int _resistance;

    public TherEx()
    {

    }
    public override void SpecificActivity()
    {
        Console.Write("\r\nThe therapeutic exercises include:\r\n    1. Bicep Curls\r\n    2. Tricep Extensions\r\n    3. Lateral Raises\r\n    4. NuStep Machine\r\nWhich exercise do you want to add to your note? ");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            _activityName = "Bicep Curls";
            Weights();
        }
        else if (choice == 2)
        {
            _activityName = "Tricep Extensions";
            Weights();
        }
        else if (choice == 3)
        {
            _activityName = "Lateral Raises";
            Weights();
        }
        else if (choice == 4)
        {
            _activityName = "NuStep Machine";
            Console.Write("\r\nWhat was the machine resistance level (1-6)? ");
            _resistance = int.Parse(Console.ReadLine());
            Console.Write("How many minutes did they use the NuStep machine? ");
            _time = float.Parse(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("\r\nPlease select a number 1-4.");
        }
    }
    public override string DisplayInfo()
    {
        string info = "";
        if (_activityName == "NuStep Machine")
        {
            info = $"Activity name : {_activityName}; Resistance level : {_resistance}; Time using machine : {_time}";
        }
        else
        {
            info = $"Activity name : {_activityName}; Sets : {_sets}; Reps : {_reps}; Weight : {_weight}";
        }
        return info;
    }
    public void Weights()
    {
        Console.Write("How many sets did the patient do? ");
        _sets = int.Parse(Console.ReadLine());
        Console.Write("How many repititions per set did the patient do? ");
        _reps = int.Parse(Console.ReadLine());
        Console.Write("How many pounds did the patient use? ");
        _weight = int.Parse(Console.ReadLine());
    }
}