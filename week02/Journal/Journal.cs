public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry()
    {
        Entry newEntry = new Entry();
        PromptGenerator _prompt = new PromptGenerator();
        newEntry._promptText = _prompt.DisplayPrompt();
        Console.Write("Enter text: ");
        newEntry._entryText = Console.ReadLine();
        _entries.Add(newEntry);
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
        
    }

}