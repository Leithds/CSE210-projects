public class Goal
{
    public string ShortName { get; private set; }
    public string Description { get; private set; }
    public string Points { get; private set; }

    public Goal(string name, string description, string points)
    {
        ShortName = name;
        Description = description;
        Points = points;
    }

    public virtual void RecordEvent()
    {
    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual int GetBonus()
    {
        return 0;
    }

    public virtual string GetDetails()
    {
        return $"{ShortName}: {Description}";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{ShortName}: {Description}";
    }
}