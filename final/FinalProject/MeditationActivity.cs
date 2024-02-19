public class MeditationActivity : Activity
{
    public MeditationActivity() : base("Meditation Activity", "Take deep breaths and relax, Then return to normal breathing. \nFocus on your breathing.")
    {
    }
protected void ShowCountDown(int minutes)
{
    int totalSeconds = minutes * 60;

    for (int i = totalSeconds; i > 0; i--)
    {
        TimeSpan timeRemaining = TimeSpan.FromSeconds(i);
        string countdownText = $"{timeRemaining.Minutes:D2}:{timeRemaining.Seconds:D2} ";
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
        base.PrepTime();

        Console.WriteLine("Starting meditation activity...");
    }
}