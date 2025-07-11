using System.Diagnostics.CodeAnalysis;

public class Entry
{
    string _date = DateTime.Now.ToString("M/d/yyyy");
    public string _promptText;
    public string _entryText;
    public void DisplayEntry()
    {
        string finalEntry = ($"Date: {_date} - {_promptText} | {_entryText}");
        Console.WriteLine(finalEntry);
    }
}