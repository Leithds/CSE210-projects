public class LetterActivity : Activity
{
    private string _letter;

    public LetterActivity(string letter) : base("Letter Activity", "Encouraging letters to yourself. \nRemind yourself why you are doing this.")
    {
        _letter = letter;
    }

    public void GetRandomPrompt()
    {
        Console.WriteLine("Prompt: Think about your progress so far and write an encouraging letter to yourself.");
    }

    public void GetRandomLetter()
    {
        Console.WriteLine($"Your letter: {_letter}");
    }
}