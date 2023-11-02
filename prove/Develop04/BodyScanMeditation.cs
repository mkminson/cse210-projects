using System;

public class BodyScanMeditation : Activity
{
    private List<string> _bodyAreas = new()
        {
            "Your head, including your face, jaw and neck",
            "Your shoulders, chest and upper back",
            "Your torso all the way around from your back to your front",
            "Your hips and thighs",
            "Your knees, calfs, shins, feet and toes"
        };

    public BodyScanMeditation() : base()
    {

    }

    public void LetsScan()
    {
        string activityName = "Body Scan Meditation";
        string activityDescription = "In this activity you will be given an area of your body to think about. As you breathe in and out, focus on the sensation in that area of your body. " +
        "If there is tension in this part of your body, inahle and exhale to release the tension. You will do this with your eyes closed, and you will hear a beep " +
        "when the activity is finished, and it's time to open your eyes.";
        base.DisplayStartMessage(activityName, activityDescription);
        base.DisplayDurationPrompt();
        base.DisplayGetReady();
        DisplayScanPrompt();
        Console.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(base.GetActivityDUration());
        while (DateTime.Now <= endTime)
        {
            Console.Write(". ");
            Thread.Sleep(1000);
        }
        Console.Beep();
        base.DisplayEndMessage();
    }

    public void DisplayScanPrompt()
    {
        Console.WriteLine("\r\nThink of the area of you body listed here:");
        Random ran = new Random();
        int randomIndex = ran.Next(_bodyAreas.Count);
        Console.WriteLine($"\r\n---{_bodyAreas[randomIndex]}---");
        Console.WriteLine("\r\nWhen you are ready to begin, press enter to continue and then close your eyes and complete the body scan meditation until you hear the beep.");
        Console.ReadLine();
    }
}