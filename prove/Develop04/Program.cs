using System;

class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Start breathing activity");
            Console.WriteLine("    2. Start reflecting activity");
            Console.WriteLine("    3. Start listing activity");
            Console.WriteLine("    4. Quit");
            Console.Write("Select a choice from the menu: ");

            int option = int.Parse(Console.ReadLine());
            if(option == 1)
            {
                Console.Clear();
                Breathing breathing = new Breathing();
                breathing.LetsBreathe();
            }
            else if(option == 2)
            {
                Console.Clear();
                Reflection reflect = new Reflection();
                reflect.LetsReflect();
            }
            else if(option == 3)
            {
                Console.Clear();
                Listing listing = new Listing();
                listing.LetsList();
            }
            else
                return;

        //test for pause animation        
        // Activity activity1 = new Activity();
        // activity1.PauseAnimation(10);
        }

    }
}