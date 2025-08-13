using System.Diagnostics.CodeAnalysis;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {

    }
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine(_description);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have completed {_duration} seconds in the {_name}");
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        List<string> animatedSpinner = new List<string>();
        animatedSpinner.Add("|");
        animatedSpinner.Add("/");
        animatedSpinner.Add("-");
        animatedSpinner.Add("\\");
        animatedSpinner.Add("|");
        animatedSpinner.Add("/");
        animatedSpinner.Add("-");
        animatedSpinner.Add("\\");
        int i = 0;
        DateTime currentTime = DateTime.Now;
        while (currentTime < endTime)
        {
            currentTime = DateTime.Now;
            if (currentTime == endTime)
            {
                break;
            }
            string s = animatedSpinner[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            if (i >= animatedSpinner.Count())
            {
                i = 0;
            }
        }
    }
    
}