using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    private const string StreakFileName = "Streak.txt";

    public static void Main(string[] args)
    {
        Records records = new Records();

        while (true)
        {
            bool success = CheckInRecordSuccess();
            records.CheckSuccess(success);
            DisplayMainMenu();
        }
    }

    private static bool CheckInRecordSuccess()
    {
        if (!File.Exists(StreakFileName))
        {
            File.WriteAllText(StreakFileName, DateTime.Now.ToString());
            return true;
        }
        else
        {
            string lastCheckInString = File.ReadAllText(StreakFileName);
            if (DateTime.TryParse(lastCheckInString, out DateTime lastCheckIn))
            {
                TimeSpan timeElapsed = DateTime.Now - lastCheckIn;
                if (timeElapsed.TotalDays >= 1)
                {
                    File.WriteAllText(StreakFileName, DateTime.Now.ToString());
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Error: Unable to parse last check-in time.");
                return false;
            }
        }
    }

    private static void DisplayMainMenu()
    {
        Console.WriteLine("\nChoose an option:");
        Console.WriteLine("1. Check-in");
        Console.WriteLine("2. Goals");
        Console.WriteLine("3. Letters");
        Console.WriteLine("4. Meditation");
        Console.WriteLine("5. Panic Button");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Did you have a successful day? (Y/N): ");
                char response = Console.ReadLine().ToUpper()[0];

                if (response == 'Y')
                {
                    Console.WriteLine("\nCongratulations! Keep up the good work!");
                }
                else if (response == 'N')
                {
                    Console.WriteLine("\nIt's okay. Tomorrow is another day.");
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }

                break;

            case 2:
                Console.WriteLine("\nGoals Menu:");
                Console.WriteLine("1. List Goals");
                Console.WriteLine("2. Set New Goal");

                int goalChoice = Convert.ToInt32(Console.ReadLine());

                switch (goalChoice)
                {
                    case 1:
                        DisplayGoals();
                        break;

                    case 2:
                        SetNewGoal();
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                break;

            case 3:
                Console.WriteLine("\nLetters Menu:");
                Console.WriteLine("1. Edit Letters");

                int letterChoice = Convert.ToInt32(Console.ReadLine());

                switch (letterChoice)
                {
                    case 1:
                        EditLetters();
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                break;

            case 4:
                MeditationActivity meditation = new MeditationActivity();
                meditation.Run();
                break;

            case 5:
                PanicButton.Run();
                break;

            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }

    private static void DisplayGoals()
    {
        Miscellaneous misc = new Miscellaneous();
        misc.ListGoals();
    }

    private static void SetNewGoal()
    {
        Miscellaneous misc = new Miscellaneous();
        Console.WriteLine("\nEnter your new goal:");
        string newGoal = Console.ReadLine();
        misc.EditGoals(newGoal);
        Console.WriteLine("New goal set!");
    }

    private static void EditLetters()
    {
        Miscellaneous misc = new Miscellaneous();
        Console.WriteLine("\nEnter the text of the letter:");
        string newText = Console.ReadLine();
        misc.EditLetters(newText);
        Console.WriteLine("Letter added successfully!");
    }
}