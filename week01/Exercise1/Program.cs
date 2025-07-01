using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.WriteLine("What is your first name? ");
        string name = Console.ReadLine();
        Console.WriteLine("What is your last name? ");
        string last_name = Console.ReadLine();
        Console.Write($"Your name is {last_name}, {name} {last_name}.");
    }
}