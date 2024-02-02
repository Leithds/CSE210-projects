class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("\n--Listing Activity--\n", "\nReflect on the good things in your life by listing as many things as you can in a certain area.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        int remainingDuration = _duration;

        while (remainingDuration > 0)
        {
            GetRandomPrompt();
            GetListFromUser(ref remainingDuration);
        }

        DisplayEndingMessage();
    }

    private void GetRandomPrompt()
    {
        Console.WriteLine($"Reflect on: {_prompts[GetRandomPromptIndex()]}");
        ShowCountDown(5);
    }

    private int GetRandomPromptIndex()
    {
        return new Random().Next(0, _prompts.Count);
    }

    private void GetListFromUser(ref int remainingDuration)
    {
        DateTime startTime = DateTime.Now;
        List<string> itemsList = new List<string>();

        Console.WriteLine($"List items (you have {remainingDuration} seconds, press Enter after each item, type 'done' when finished):");

        while (remainingDuration > 0)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done")
                break;

            itemsList.Add(input);

            remainingDuration = _duration - (int)(DateTime.Now - startTime).TotalSeconds;
        }

        Console.WriteLine($"You listed {itemsList.Count} items.");
    }
}