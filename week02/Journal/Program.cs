using System;
using System.Xml.Serialization;

class Program
{
    /*I added a question to see if the user wants a question or just wants to write something. */
    /*I also added lines to tell the user what the computer is doing ("Loading file", "Saving the following entries", etc.)*/
    static void Main(string[] args)
    {
        Journal _myJournal = new Journal();
        Boolean loop = true;
        while (loop == true)
        {
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1_Write.");
            Console.WriteLine("2_Display.");
            Console.WriteLine("3_Load.");
            Console.WriteLine("4_Save.");
            Console.WriteLine("5_Quit.");
            Console.Write("Choice: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                _myJournal.AddEntry();
            }
            else if (choice == 2)
            {
                _myJournal.DisplayJournal();
            }
            else if (choice == 3)
            {
                Console.Write("Enter Filename: ");
                string fileName = Console.ReadLine();
                Console.WriteLine("Loading file...");
                Console.WriteLine("");
                _myJournal.LoadFromFile(fileName);
            }
            else if (choice == 4)
            {
                Console.Write("Enter Filename: ");
                string fileName = Console.ReadLine();
                _myJournal.SaveToFile(fileName);
            }
            else if (choice == 5)
            {
                break;
            }
            else
            {
                Console.WriteLine("That is not an option.");
            }
        }

    }
}