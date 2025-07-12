using System.Diagnostics.CodeAnalysis;

public class Entry
{
    string _date = DateTime.Now.ToString("M/d/yyyy");
    public string _promptText;
    public string _entryText;
    public string DisplayEntry()
    {
        string _finalEntry = ($"Date: {_date} - {_promptText} | {_entryText}");
        Console.WriteLine(_finalEntry);
        return _finalEntry;
    }
}