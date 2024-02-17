public class PanicButton
{
    private readonly BreathingActivity breathingActivity = new BreathingActivity();
    private readonly LetterActivity letterActivity = new LetterActivity();
    private readonly GoalSettingActivity goalSettingActivity = new GoalSettingActivity();

    public void HandlePanic()
    {
        Random random = new Random();
        int choice = random.Next(1, 4);

        switch (choice)
        {
            case 1:
                breathingActivity.GuideBreathing(30);
                break;
            case 2:
                letterActivity.WriteLetter("You can overcome this!");
                break;
            case 3:
                goalSettingActivity.SetGoal("Milestone", "Stay clean for another day!");
                break;
        }
    }
}