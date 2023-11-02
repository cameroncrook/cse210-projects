using System.Diagnostics.Contracts;

public class BreathingActivity : Activity
{
    private int _countdown;

    public BreathingActivity()
        : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        _countdown = 6;
    }

    public void RunActivity(int duration)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            BreathIn();
            BreathOut();
        }
    }

    public void BreathIn()
    {
        Console.Write("\nBreathe In...");
        base.Countdown(_countdown);
    }

    public void BreathOut()
    {
        Console.Write("\nNow Breathe Out...");
        base.Countdown(_countdown);
    }
}