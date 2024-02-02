class BreathingActivity : Activity // This has been broken for sooooooooo long :(
{
    public BreathingActivity() : base("\n--Breathing Activity--\n", "\nRelax by walking through breathing in and out slowly.")
    {
    }

    public void Run()
    {
        ShowCountDown(5);
        DisplayStartingMessage();

        Console.WriteLine("Breathe in...");
        ShowCountDown(4);

        Console.WriteLine("Hold...");
        ShowCountDown(7);

        Console.WriteLine("Breathe out...");
        ShowCountDown(8);

        DisplayEndingMessage();
    }
}