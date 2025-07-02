using System;
using System.Formats.Asn1;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        string choice = "Yes";
        do
        {
            string success = "No";
            int times = 0;
            Random randomGenerator = new Random();
            Console.WriteLine("Guess the magic number. ");
            int magicNumber = randomGenerator.Next(1, 100);
            while (success == "No")
            {
                Console.WriteLine("What is your guess? ");
                string guessInput = Console.ReadLine();
                int guessNumber = int.Parse(guessInput);
                times += 1;

                if (guessNumber == magicNumber)
                {
                    Console.WriteLine("You guessed it!");
                    success = "Yes";
                }
                else if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
            }
            Console.WriteLine($"Number of tries: {times}");
            Console.Write("Do you want to play again? ");
            choice = Console.ReadLine().ToLower();
        } while (choice == "yes");
    }
}