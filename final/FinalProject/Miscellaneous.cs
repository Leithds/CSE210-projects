public class Miscellaneous
{
    private const string GoalsFileName = "Goals.txt";
    private const string LettersFileName = "Letters.txt";
    private Dictionary<int, string> _goals;
    private Dictionary<int, string> _letters;

    public Miscellaneous()
    {
        _goals = new Dictionary<int, string>();
        _letters = new Dictionary<int, string>();
        LoadGoals();
        LoadLetters();
    }

    public void ListGoals()
    {
        Console.WriteLine("Current goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{goal.Key}: {goal.Value}");
        }
    }

    public void EditGoals(string newGoal)
    {
        _goals.Add(_goals.Count + 1, newGoal);
        SaveGoals();
    }

    public void SaveGoals()
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(GoalsFileName))
            {
                foreach (var goal in _goals)
                {
                    writer.WriteLine($"{goal.Key},{goal.Value}");
                }
            }
            Console.WriteLine("Goals saved successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving goals: {ex.Message}");
        }
    }

    public void LoadGoals()
    {
        try
        {
            _goals.Clear();
            if (File.Exists(GoalsFileName))
            {
                using (StreamReader reader = new StreamReader(GoalsFileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 2 && int.TryParse(parts[0], out int key))
                        {
                            _goals[key] = parts[1];
                        }
                    }
                }
                Console.WriteLine("Goals loaded successfully!");
            }
            else
            {
                Console.WriteLine("No saved goals found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading goals: {ex.Message}");
        }
    }

    public void EditLetters(string newText)
    {
        _letters.Add(_letters.Count + 1, newText);
        SaveLetters();
    }

    public void SaveLetters()
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(LettersFileName))
            {
                foreach (var letter in _letters)
                {
                    writer.WriteLine($"{letter.Key},{letter.Value}");
                }
            }
            Console.WriteLine("Letters saved successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving letters: {ex.Message}");
        }
    }

    public void LoadLetters()
    {
        try
        {
            _letters.Clear();
            if (File.Exists(LettersFileName))
            {
                using (StreamReader reader = new StreamReader(LettersFileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 2 && int.TryParse(parts[0], out int key))
                        {
                            _letters[key] = parts[1];
                        }
                    }
                }
                Console.WriteLine("Letters loaded successfully!");
            }
            else
            {
                Console.WriteLine("No saved letters found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading letters: {ex.Message}");
        }
    }

    public Dictionary<int, string> GetLetters()
    {
        return _letters;
    }
}