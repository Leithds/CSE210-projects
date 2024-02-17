public class BreathingActivity : Activity
{
    public void GuideBreathing(int durationSeconds)
    {
        Console.WriteLine("Breathing Exercise:");
        for (int i = durationSeconds; i > 0; i--)
        {
            Console.WriteLine($"{i} seconds remaining...");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Breathing Exercise completed.\n");
    }
}