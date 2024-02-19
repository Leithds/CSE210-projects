public class BreathingActivity : Activity
{
    public BreathingActivity(string v) : base("Breathing Activity", "Take deep breaths and relax.")
    {
    }
    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            string countdownText = $"{i} ";
            Console.Write(countdownText);
            System.Threading.Thread.Sleep(1000);

            Console.SetCursorPosition(Console.CursorLeft - countdownText.Length, Console.CursorTop);

            Console.Write(new string(' ', countdownText.Length));

            Console.SetCursorPosition(Console.CursorLeft - countdownText.Length, Console.CursorTop);
        }

        Console.WriteLine("\n");
    }

    public override void Run()
    {
        base.Run();

        Console.WriteLine("Breathe in...");
        ShowCountDown(4);

        Console.WriteLine("Hold...");
        ShowCountDown(7);

        Console.WriteLine("Breathe out...");
        ShowCountDown(8);

        DisplayEndAffirmation();
    }
}