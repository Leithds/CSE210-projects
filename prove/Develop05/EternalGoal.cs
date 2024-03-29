public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
    }
    public override void RecordEvent()
    {
        Console.WriteLine($"Recorded event for {ShortName}.");
    }
    public override bool IsComplete()
    {
        return false;
    }
public override string GetStringRepresentation()
{
    return $"{ShortName}: {Description}. Eternal goal.";
}
}