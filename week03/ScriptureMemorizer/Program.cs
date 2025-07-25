/*I changed it to allow the user to Enter whatever scripture the user wants to memorize, 
They just need to Copy and Paste the text of the scripture*/
using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Scripture s = new Scripture();

        Console.WriteLine("What is the scripture reference? ");
        Console.Write("Enter Book: ");
        string referenceBook = Console.ReadLine();
        Console.Write("Enter Chapter: ");
        int referenceChapter = int.Parse(Console.ReadLine());
        Console.Write("Enter Starting Verse(s): ");
        int referenceVerse = int.Parse(Console.ReadLine());
        Console.Write("Enter Ending Verse(s): ");
        string referenceEndVerseString = Console.ReadLine();

        Console.Write("Enter Text: ");
        string text = Console.ReadLine();

        s.SetUserScripture(referenceBook, referenceChapter, referenceVerse, referenceEndVerseString, text);
        s.DisplayScripture();
        s.SeparateVerseIntoWords();
        string hideWordsChoice = "";
        while (hideWordsChoice.ToLower() != "q")
        {
            if (hideWordsChoice.ToLower() == "q")
            {
                break;
            }
            Console.Write("Press enter to hide words or 'q' to quit: ");
            hideWordsChoice = Console.ReadLine();
            if (hideWordsChoice.ToLower() != "q")
            {
                s.HideRandomWords();
                s.GetDisplayText();
                Console.WriteLine();
                bool finished = s.IsCompletelyHidden();
                if (finished == true)
                {
                    break;
                }
            }
        }
        
    }
}