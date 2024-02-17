public class GoalSettingActivity : Activity
{
    public void SetGoal(string milestone, string goal)
    {
        using (StreamWriter sw = File.AppendText("final.txt"))
        {
            sw.WriteLine($"{milestone}: {goal}");
        }
        Console.WriteLine($"Goal set for {milestone}: {goal}");
    }
}
