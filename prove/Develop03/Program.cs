using System;
// I added a prompt to ask the user how many words they want to hide.
class Program
{
    static void Main()
    {
        Console.WriteLine("What is the scripture reference? (e.g. John 3:16):");
        string referenceInput = Console.ReadLine();

        Console.WriteLine("Type the scripture's text:");
        string textInput = Console.ReadLine();

        Reference userReference = ParseReference(referenceInput);
        Scripture userScripture = new Scripture(userReference, textInput);

        Console.WriteLine(userScripture.GetDisplayText());

        while (!userScripture.IsCompletelyHidden())
        {
            Console.WriteLine("Hit enter to hide words or type quit to end this:");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
                break;

            Console.WriteLine("How many words do you wnt to hide:");
            if (int.TryParse(Console.ReadLine(), out int wordsToHide))
            {
                userScripture.HideRandomWords(wordsToHide);
                Console.Clear();
                Console.WriteLine(userScripture.GetDisplayText());
            }
            else
            {
                Console.WriteLine("Please enter a number that is equel to or lessor");
                Console.WriteLine("than the total number of words left.");
            }
        }
    }
    static Reference ParseReference(string input)
    {
        string[] parts = input.Split(' ');

        if (parts.Length == 2)
        {
            string[] chapterVerse = parts[1].Split(':');

            if (chapterVerse.Length == 2 && int.TryParse(chapterVerse[0], out int chapter) && int.TryParse(chapterVerse[1], out int verse))
            {
                return new Reference(parts[0], chapter, verse);
            }
        }
        throw new ArgumentException("Invalid scripture reference format");
    }
}