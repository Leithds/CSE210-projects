using System;

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
        Console.WriteLine("Choose an option:");
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
                        Console.WriteLine("Congratulations! Keep up the good work!");
                    }
                    else if (response == 'N')
                    {
                        Console.WriteLine("It's okay. Tomorrow is another day.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }

                    break;

                case 2:
                    Console.WriteLine("Goals Menu:");
                    Console.WriteLine("1. List Goals");
                    Console.WriteLine("2. Set New Goal");

                    int goalChoice = Convert.ToInt32(Console.ReadLine());

                    switch (goalChoice)
                    {
                        case 1:
                            Miscellaneous.ListGoals(goals);
                            break;

                        case 2:
                            Console.WriteLine("Enter your new goal:");
                            string newGoal = Console.ReadLine();
                            goals.Add(newGoal);
                            Console.WriteLine("New goal set!");
                            break;

                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }

                    break;

                case 3:
                    Console.WriteLine("Letters Menu:");
                    Console.WriteLine("1. Edit Letters");

                    int letterChoice = Convert.ToInt32(Console.ReadLine());

                    switch (letterChoice)
                    {
                        case 1:
                            Miscellaneous.EditLetters(letters);
                            break;

                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }

                    break;

                case 4:
                    activities[1].Run();
                    break;

                case 5:
                    PanicButton.Run(activities);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
    }
}