public class MeditationActivity : Activity
{
    public void GuideMeditation(int durationMinutes)
    {
        Console.WriteLine("Meditation Exercise:");
        Console.WriteLine("Focus on your breath...");
        Thread.Sleep(durationMinutes * 1000 * 60);
        Console.WriteLine("Meditation completed.\n");
    }
}
