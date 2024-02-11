public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
    }
    public override void RecordEvent()
    {
        Console.WriteLine($"{ShortName} completed!");
    }
    public override bool IsComplete()
    {
        return true;
    }
    public override string GetStringRepresentation()
    {
        return $"{ShortName}: {Description}. Simple goal.";
    }
}