public class ReflectingActivity : Activity
{
    protected List<string> _prompts;
    protected List<string> _questions;
    public ReflectingActivity(int duration)
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _duration = duration;
    }
    public string GetRandomPrompt()
    {
        _prompts = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        var randomPrompt = _prompts[index];
        return randomPrompt;
    }
    public string GetRandomQuestion()
    {
        _questions = [ "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"];
        Random rnd = new Random();
        int index = rnd.Next(_questions.Count);
        string randomQuestion = _questions[index];
        return randomQuestion;
    }
    public void DisplayPrompt()
    {
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine(randomPrompt);
        Console.ReadLine();
    }
    public void DisplayQuestion()
    {
        string randomQuestion = GetRandomQuestion();
        Console.WriteLine(randomQuestion);
    }
    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(5);
        Console.WriteLine();
        DisplayPrompt();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime < endTime)
        {
            currentTime = DateTime.Now;
            if (currentTime == endTime)
            {
                break;
            }

            DisplayQuestion();
            ShowSpinner(10);
        }
        DisplayEndingMessage();
    }
}