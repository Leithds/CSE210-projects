using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nThe Great Celestial Race");
            Console.WriteLine("1. Display Player's Score");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Create Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    goalManager.DisplayPlayerInfo();
                    break;
                case "2":
                    goalManager.ListGoalDetails();
                    break;
                case "3":
                    CreateGoal(goalManager);
                    break;
                case "4":
                    RecordEvent(goalManager);
                    break;
                case "5":
                    goalManager.SaveGoals("goals.txt");
                    break;
                case "6":
                    goalManager.LoadGoals("goals.txt");
                    break;
                case "7":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
    static void CreateGoal(GoalManager goalManager)
    {
        Console.WriteLine("\nCreate Goal");
        Console.Write("Enter goal type (Simple/Eternal/Checklist): ");
        string type = Console.ReadLine();
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points for the goal: ");
        string points = Console.ReadLine();

        if (type.ToLower() == "checklist")
        {
            Console.Write("Enter target count for the checklist: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points for completing the checklist: ");
            int bonus = int.Parse(Console.ReadLine());

            goalManager.CreateGoal(type, name, description, points, target, bonus);
        }
        else
        {
            goalManager.CreateGoal(type, name, description, points);
        }

        Console.WriteLine("Goal created successfully.");
    }

    static void RecordEvent(GoalManager goalManager)
    {
        Console.WriteLine("\nRecord Event");
        Console.Write("Enter the goal name: ");
        string goalName = Console.ReadLine();
        goalManager.RecordEvent(goalName, "Goals.txt");
    }
}