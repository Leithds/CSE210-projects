class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"{_name} - {_description}");
        Console.Write("Enter duration in seconds: ");
        _duration = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Prepare to begin...\n");
        System.Threading.Thread.Sleep(2000);
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine("\nGood job!\n");
        Console.WriteLine($"You have completed {_name} for {_duration} seconds.\n");
        System.Threading.Thread.Sleep(2000);
    }

    protected void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        string[] spinnerSymbols = { "/", "-", "\\", "|" }; // I do not know why \ needed to be \\... I may never know.
        int symbolIndex = 0;

        while ((DateTime.Now - startTime).TotalSeconds < seconds)
        {
            Console.Write(spinnerSymbols[symbolIndex]);
            System.Threading.Thread.Sleep(100);

            Console.Write("\b \b");
            symbolIndex = (symbolIndex + 1) % spinnerSymbols.Length;
        }

        Console.WriteLine();
    }
    protected void ShowCountDown(int seconds) // I needed stack overflow to make the numbers not keep moving further right.
    {
        for (int i = seconds; i > 0; i--)
        {
            string countdownText = $"{i} ";
            Console.Write(countdownText);
            System.Threading.Thread.Sleep(1000);

            Console.SetCursorPosition(Console.CursorLeft - countdownText.Length, Console.CursorTop);

            Console.Write(new string(' ', countdownText.Length));
            
            Console.SetCursorPosition(Console.CursorLeft - countdownText.Length, Console.CursorTop);
        }

        Console.WriteLine("\n");
    }
}