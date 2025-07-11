using System;
using System.Xml.Serialization;

class Program
{
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
                break
            }
            else if (choice == 4)
            {
                
            }
            else if (choice == 5)
            {
                break;
            }
        }

    }
}