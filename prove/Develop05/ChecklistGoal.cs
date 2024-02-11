public class ChecklistGoal : Goal
{
    public int _amountCompleted;
    public int _target;
    public int _bonus;

    public int AmountCompleted { get; internal set; }
    public object Target { get; private set; }

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"{ShortName} completed {_amountCompleted}/{_target} times.");
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override int GetBonus()
    {
        if (IsComplete())
            return _bonus;
        return 0;
    }
    public override string GetDetails()
    {
        return $"{ShortName}: {Description}. Completed {_amountCompleted}/{_target} times.";
    }
public override string GetStringRepresentation()
{
    return $"{ShortName}: {Description}. Checklist goal. Completed {AmountCompleted}/{Target} times.";
}
}