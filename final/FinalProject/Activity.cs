public class Activity
{
    protected string _name;
    protected int _duration;
    protected string _affirmation;

    public Activity(string name, string affirmation)
    {
        _name = name;
        _affirmation = affirmation;
    }

    public virtual void Run()
    {
        Console.WriteLine($"Starting {_name}...");
        Console.WriteLine(_affirmation);
    }

    public void DisplayEndAffirmation()
    {
        Console.WriteLine("Keep up the good work!");
    }

    public void PrepTime()
    {
        Console.WriteLine("Get ready...");
        System.Threading.Thread.Sleep(2000);
    }
}