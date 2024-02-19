public class Activity
{
    protected string _name;
    protected int _duration;
    protected string _affirmation;
    private string v1;
    private string v2;

    public Activity(string name, int duration, string affirmation)
    {
        _name = name;
        _duration = duration;
        _affirmation = affirmation;
    }

    public Activity(string v1, string v2)
    {
        this.v1 = v1;
        this.v2 = v2;
    }

    public virtual void Run()
    {
        Console.WriteLine($"Starting {_name}...");
        Console.WriteLine(_affirmation);
    }

    public void DisplayAffirmation()
    {
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
