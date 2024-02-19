public class Records
{
    private const string StreakFileName = "Streak.txt";
    private int _successStreak;
    private Miscellaneous _miscellaneous;

    public Records()
    {
        _successStreak = 0;
        _miscellaneous = new Miscellaneous();
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
        Dictionary<int, string> goals = _miscellaneous.GetGoals();
        foreach (var goal in goals)
        {
            Console.WriteLine($"Key: {goal.Key}, Value: {goal.Value}");
        }
    }

    public void ReadRecentLetter()
    {
        Console.WriteLine("Recent Letter:");
        Dictionary<int, string> letters = _miscellaneous.GetLetters();
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