public class PanicButton
{
    private bool _urges;

    public PanicButton()
    {
        _urges = false;
    }

    public void Run()
    {
    }

    public Activity GetRandomActivity()
    {
        Random rnd = new Random();
        int choice = rnd.Next(1, 4);

        switch (choice)
        {
            case 1:
                return new BreathingActivity("Take deep breaths and relax.");
            case 2:
                return new LetterActivity("Write a letter to yourself.");
            case 3:
                return new GoalSettingActivity("Set new goals.", "Stay motivated and focused.");
            default:
                return new BreathingActivity("Take deep breaths and relax.");
        }
    }

    internal static void Run(Activity[] activities)
    {
        throw new NotImplementedException();
    }
}