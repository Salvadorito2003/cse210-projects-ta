public class BreathingActivity : Activity
{
    public BreathingActivity(int duration)
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = duration;
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(5);
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
            Console.WriteLine("Breathe in: ");
            ShowCountDown(4);
            Console.WriteLine("Hold: ");
            ShowCountDown(8);
            Console.WriteLine("Breathe out: ");
            ShowCountDown(7);
        }
        DisplayEndingMessage();
    }
}