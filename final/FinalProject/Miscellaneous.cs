public class Miscellaneous
{
    private const string GoalsFileName = "Goals.txt";
    private const string LettersFileName = "Letters.txt";
    private int _goalCounter;
    private int _letterCounter;
    private Dictionary<int, string> _goals;
    private Dictionary<int, string> _letters;

    public Miscellaneous()
    {
        _goals = new Dictionary<int, string>();
        _letters = new Dictionary<int, string>();
        _goalCounter = 1;
        _letterCounter = 1;
    }

    public void Start()
    {
        LoadGoals();
        LoadLetters();
    }

    public Dictionary<int, string> GetGoals()
    {
        return _goals;
    }

    public Dictionary<int, string> GetLetters()
    {
        return _letters;
    }

    public void ListGoals()
    {
        Console.WriteLine("Current goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{goal.Key}: {goal.Value}");
        }
    }

    public void EditGoals()
    {
        Console.WriteLine("Enter a new goal:");
        string newGoal = Console.ReadLine();
        _goals[_goalCounter] = newGoal;
        _goalCounter++;
        SaveGoals();
        Console.WriteLine("Goal added successfully!");
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
                            if (key >= _goalCounter)
                            {
                                _goalCounter = key + 1;
                            }
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

    public void EditLetters()
    {
        Console.WriteLine("Enter the text of the letter:");
        string newText = Console.ReadLine();
        _letters[_letterCounter] = newText;
        _letterCounter++;
        SaveLetters();
        Console.WriteLine("Letter added successfully!");
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
                            if (key >= _letterCounter)
                            {
                                _letterCounter = key + 1;
                            }
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
}