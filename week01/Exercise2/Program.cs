using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string userImput = Console.ReadLine();
        int number = int.Parse(userImput);
        string grade = "";
        string sign = "";
        if (number >= 90)
        {
            grade = "A";
        }
        else if (number >= 80)
        {
            grade = "B";
        }
        else if (number >= 70)
        {
            grade = "C";
        }
        else if (number >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        
        if (!(grade == "A" || grade == "F") && (number % 10 >= 7))
        {
            sign = "+";
        }
        else if (!(grade == "F") && (number % 10 < 3))
        {
            sign = "-";
        }

        Console.Write($"Your grade is: {grade}{sign}");
    }

}