using System;

public class Program
{
    private readonly GoalSettingActivity goalSettingActivity = new GoalSettingActivity();
    private readonly MeditationActivity meditationActivity = new MeditationActivity();
    private readonly PanicButton panicButton = new PanicButton();

    public static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("1. Track Day (Success/Setback)");
            Console.WriteLine("2. Meditate");
            Console.WriteLine("3. Access Panic Button");
            Console.WriteLine("4. Add/Edit Goals or Review Letters");
            Console.WriteLine("5. Exit");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    
                    break;
                case 2:
                    Console.WriteLine("Enter duration for meditation (in minutes):");
                    int duration;
                    if (!int.TryParse(Console.ReadLine(), out duration))
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                        continue;
                    }
                    meditationActivity.GuideMeditation(duration);
                    break;
                case 3:
                    panicButton.HandlePanic();
                    break;
                case 4:
                    Console.WriteLine("Enter milestone (e.g., 1 day, 1 week):");
                    string milestone = Console.ReadLine();
                    Console.WriteLine("Enter goal or letter of encouragement:");
                    string content = Console.ReadLine();

                    if (milestone.ToLower().Contains("day") || milestone.ToLower().Contains("week"))
                        goalSettingActivity.SetGoal(milestone, content);
                    else
                        Console.WriteLine("Invalid milestone for goal. Try again.");
                    break;
                case 5:
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}