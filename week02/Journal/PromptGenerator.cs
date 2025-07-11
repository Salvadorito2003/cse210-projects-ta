using System.Security.Cryptography.X509Certificates;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
        {
            "What was the best part of your day?",
            "What were you grateful for today?",
            "How did you serve the Lord today?",
            "Who was there to support you today?",
            "How did the Lord bless you today?"
        };
    public static Random rnd = new Random();

    public string DisplayPrompt()

    {
        int r = rnd.Next(_prompts.Count);
        string randomPrompt = _prompts[r];
        Console.WriteLine(randomPrompt);
        return randomPrompt;
        
    }

}