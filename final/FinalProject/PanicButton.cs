public class PanicButton
{
    public static void Run()
    {
        Random rnd = new Random();
        int choice = rnd.Next(1, 4);

        switch (choice)
        {
            case 1:
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                break;

            case 2:
                LetterActivity letterActivity = new LetterActivity("Write a letter to yourself.");
                letterActivity.Run();
                break;

            case 3:
                GoalSettingActivity goalSettingActivity = new GoalSettingActivity("Stay motivated and focused.");
                goalSettingActivity.Run();
                break;

            default:
                BreathingActivity defaultActivity = new BreathingActivity();
                defaultActivity.Run();
                break;
        }
    }
}
