using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        string choice = "0";
        while (choice != "4")
        {
            Console.WriteLine("Choose an activity: ");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choice: ");
            choice = Console.ReadLine();
            if (choice == "4")
            {
                break;
            }
            Console.Write("How many seconds do you want this activity to last? ");
            int duration = int.Parse(Console.ReadLine());
            if (choice == "1")
            {
                BreathingActivity breathingAct1 = new BreathingActivity(duration);
                breathingAct1.Run();
            }
            else if (choice == "2")
            {
                ReflectingActivity reflectingAct1 = new ReflectingActivity(duration);
                reflectingAct1.Run();
            }
            else if (choice == "3")
            {
                ListingActivity listingAct1 = new ListingActivity(duration);
                listingAct1.Run();
            }
        }
            
    }
}