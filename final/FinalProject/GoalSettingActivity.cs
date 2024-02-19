public class GoalSettingActivity : Activity
{
    private string _goals;

    public GoalSettingActivity(string goals) : base("Goal Setting Activity", "Set new goals.")
    {
        _goals = goals;
    }

    public override void Run()
    {
        base.Run();
        Console.WriteLine("Your current goals:");
        Console.WriteLine(_goals);
        DisplayEndAffirmation();
    }
}