using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("    1. Start breathing activity");
        Console.WriteLine("    2. Start reflecting activity");
        Console.WriteLine("    3. Start listing activity");
        Console.WriteLine("    4. Quit");
        Console.Write("Select a choice from the menu: ");

        int option = int.Parse(Console.ReadLine());
        if(option == 1)
        {

        }

        Activity activity1 = new Activity();
        activity1.PauseAnimation();
    }
}