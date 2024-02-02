class ReflectingActivity : Activity
{
    private string[] _prompts =
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _questions =
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "What will you do to remember what you felt and learned?",
        "Can someone else learn from this?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() : base("\n--Reflecting Activity--\n", "\nReflect on times when you have shown strength and resilience.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.CursorVisible = false; // I wanted to remove the rectangle thing that shows they can type to not be so distracting.

        string prompt = _prompts[GetRandomPrompt()];
        Console.WriteLine($"Reflect on: {prompt}");
        ShowSpinner(3);

        int remainingDuration = _duration - 3;

        List<string> shuffledQuestions = new List<string>(_questions);
        Shuffle(shuffledQuestions);

        foreach (string randomQuestion in shuffledQuestions)
        {
            if (remainingDuration <= 0)
                break;

            Console.WriteLine(randomQuestion);
            ShowSpinner(9);

            remainingDuration -= 9;
        }

        while (remainingDuration > 0)
        {
            ShowSpinner(1);
            remainingDuration -= 1;
        }

        DisplayEndingMessage();
    }

    private int GetRandomPrompt()
    {
        return random.Next(0, _prompts.Length);
    }

    private int GetRandomQuestion()
    {
        return random.Next(0, _questions.Length);
    }

    private static readonly Random random = new Random();

    private void DisplayPrompt()
    {
        Console.WriteLine($"Reflect on: {_prompts[GetRandomPrompt()]}");
        ShowSpinner(3);
        DisplayQuestions();
    }

    private void DisplayQuestions()
    {
        foreach (var question in _questions)
        {
            Console.WriteLine(question);
            ShowSpinner(3);
        }

        DisplayEndingMessage();
    }

    private void Shuffle<T>(List<T> list) // This should stop the same question from popping up... or at least that is what stackoverflow said haha
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}