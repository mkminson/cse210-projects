using System;
//For my stretch activity I added a new activity called Body Scan Meditation. This activity requires the user to close their eyes so I have learned about
//and encorporated the Console.Beep() method so that you hear something when the time is up. So make sure your volume is on when doing this activity.
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Start breathing activity");
            Console.WriteLine("    2. Start reflecting activity");
            Console.WriteLine("    3. Start listing activity");
            Console.WriteLine("    4. Body Scan Meditation");
            Console.WriteLine("    5. Quit");
            Console.Write("Select a choice from the menu: ");

            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                Console.Clear();
                Breathing breathing = new Breathing();
                breathing.LetsBreathe();
            }
            else if (option == 2)
            {
                Console.Clear();
                Reflection reflect = new Reflection();
                reflect.LetsReflect();
            }
            else if (option == 3)
            {
                Console.Clear();
                Listing listing = new Listing();
                listing.LetsList();
            }
            else if (option == 4)
            {
                Console.Clear();
                BodyScanMeditation bodyScanMeditation = new BodyScanMeditation();
                bodyScanMeditation.LetsScan();
            }
            else
                return;
        }

    }
}