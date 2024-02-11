public class GoalManager
{
    public List<Goal> _goals;
    public int _score;
    public GoalManager()
    {
        _goals = new List<Goal>();
    }

    public void Start()
    {
        LoadGoals("Goals.txt");
    }

    private void LoadGoals()
    {
        throw new NotImplementedException();
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player's Score: {_score}");
    }

    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.ShortName);
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetails());
        }
    }

    public void CreateGoal(string type, string name, string description, string points, int target = 0, int bonus = 0)
    {
        switch (type.ToLower())
        {
            case "simple":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "eternal":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "checklist":
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type!");
                break;
        }
    }

    public void RecordEvent(string goalName)
    {
        int totalPointsEarned = 0;

        foreach (var goal in _goals)
        {
            if (goal.ShortName == goalName)
            {
                goal.RecordEvent();
                _score += int.Parse(goal.Points);
                if (goal.IsComplete())
                {
                    _score += goal.GetBonus();
                }
                totalPointsEarned = _score;
                SaveGoals();
                break;
            }
        }

        Console.WriteLine($"Total points earned: {totalPointsEarned}");
    }

    private void SaveGoals()
    {
        throw new NotImplementedException();
    }

    public void SaveGoals(string fileName)
    {
        List<string> lines = new List<string>();

        foreach (var goal in _goals)
        {
            string line = $"{goal.ShortName},{goal.Description},{goal.Points}";

            if (goal is ChecklistGoal checklistGoal)
            {
                line += $",{checklistGoal._amountCompleted},{checklistGoal._target},{checklistGoal._bonus}";
            }

            lines.Add(line);
        }

        try
        {
            File.WriteAllLines(fileName, lines);
            Console.WriteLine("Goals saved successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

        public void LoadGoals(string fileName)
    {
        try
        {
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                string shortName = parts[0];
                string description = parts[1];
                string points = parts[2];

                Goal goal;

                if (parts.Length > 3)
                {
                    int amountCompleted = int.Parse(parts[3]);
                    int target = int.Parse(parts[4]);
                    int bonus = int.Parse(parts[5]);

                    goal = new ChecklistGoal(shortName, description, points, target, bonus)
                    {
                        AmountCompleted = amountCompleted
                    };
                }
                else
                {
                    goal = new SimpleGoal(shortName, description, points);
                }

                _goals.Add(goal);
            }

            Console.WriteLine("Goals loaded successfully!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("No saved goals found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }
}