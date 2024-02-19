public class GoalSettingActivity : Activity
{
    private string _description;
    private string _goals;

    public GoalSettingActivity(string description, string goals) : base("Goal Setting Activity", 0, "Set new goals")
    {
        _description = description;
        _goals = goals;
    }

    public void SetGoals(string description, string goals)
    {
        _description = description;
        _goals = goals;
    }

    public string GetGoals()
    {
        return _goals;
    }
}