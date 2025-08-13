public class ListingActivity : Activity
{
    protected int _count;
    protected List<string> _prompts;

    public ListingActivity(int duration)
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = duration;
    }
    public void GetRandomPrompt()
    {
        _prompts = ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        string randomPrompt = _prompts[index];
        Console.WriteLine(randomPrompt);
    }
    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime < endTime)
        {
            currentTime = DateTime.Now;
            Console.Write("Enter: ");
            string item = Console.ReadLine();
            userList.Add(item);
        }
        return userList;
    }
    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(5);
        GetRandomPrompt();
        ShowSpinner(10);
        List<string> userList = GetListFromUser();
        Console.WriteLine($"Number of Items: {userList.Count()}");
        DisplayEndingMessage();
    }
}