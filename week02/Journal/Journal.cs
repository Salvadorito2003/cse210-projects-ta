public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry()
    {
        Entry _newEntry = new Entry();
        Console.Write("Do you want a question? (yes/no) ");
        string questionChoice = Console.ReadLine().ToLower();
        if (questionChoice == "yes")
        {
            PromptGenerator _prompt = new PromptGenerator();
            _newEntry._promptText = _prompt.DisplayPrompt();
        }
        Console.Write("Enter text: ");
        _newEntry._entryText = Console.ReadLine();
        _entries.Add(_newEntry);
    }
    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }
    public void SaveToFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        Console.WriteLine("Saving the following entries...");
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (string line in lines)
            {
                outputFile.WriteLine(line);
            }
            foreach (Entry entry in _entries)
            {
                string finalEntry = entry.DisplayEntry();
                outputFile.WriteLine(finalEntry);
            }
            Console.WriteLine("Saved to file!");
        }

    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }

}