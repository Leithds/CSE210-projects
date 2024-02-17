public class LetterActivity : Activity
{
    public void WriteLetter(string encouragement)
    {
        using (StreamWriter sw = File.AppendText("final.txt"))
        {
            sw.WriteLine($"Encouragement Letter: {encouragement}");
        }
        Console.WriteLine("Letter of encouragement written and saved.");
    }
}
