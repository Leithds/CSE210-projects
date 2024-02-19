public class Records
{
    private int _successStreak;

    public Records()
    {
        _successStreak = 0;
    }

    public void CheckSuccess(bool success)
    {
        if (success)
        {
            _successStreak++;
        }
        else
        {
            _successStreak = 0;
        }

        if (_successStreak % 3 == 0)
        {
            Console.WriteLine($"Congratulations! You've reached a milestone: {_successStreak} successful days in a row.");
            ShowRecentGoals();
            ReadRecentLetter();
            Console.WriteLine("Press Enter to return to the main menu...");
            Console.ReadLine();
        }
    }

    public void ShowRecentGoals()
    {
        Console.WriteLine("Recent Goals:");
        Miscellaneous misc = new Miscellaneous();
        misc.ListGoals();
    }

    public void ReadRecentLetter()
    {
        Console.WriteLine("Recent Letter:");
        Miscellaneous misc = new Miscellaneous();
        Dictionary<int, string> letters = misc.GetLetters();
        if (letters.Count > 0)
        {
            Console.WriteLine($"Key: {letters.Count}, Value: {letters[letters.Count]}");
        }
        else
        {
            Console.WriteLine("No letters found.");
        }
    }
}