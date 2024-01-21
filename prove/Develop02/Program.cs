using System;
using System.Collections.Generic;
using System.IO;

class JournalEntry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    public JournalEntry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    }
}

class Journal
{
    private List<JournalEntry> entries;

    public Journal()
    {
        entries = new List<JournalEntry>();
    }

    public void AddEntry(JournalEntry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}\nPrompt: {entry.Prompt}\nResponse: {entry.Response}\n");
        }
    }

    public void SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                foreach (var entry in entries)
                {
                    sw.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
                }
            }
            Console.WriteLine("Journal saved to file successfully!\n");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error saving file: {e.Message}");
        }
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();
        try
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        entries.Add(new JournalEntry(parts[1], parts[2]) { Date = parts[0] });
                    }
                }
            }
            Console.WriteLine("Journal loaded from file successfully!\n");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error loading file: {e.Message}");
        }
    }
}

class Program
{
    static void Main()
    {
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    break;

                case "2":
                    journal.DisplayEntries();
                    break;

                case "3":
                    journal.SaveToFile("journal.txt");
                    break;

                case "4":
                    journal.LoadFromFile("journal.txt");
                    break;

                case "5":
                    Console.WriteLine("Exiting the program.");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.\n");
                    break;
            }
        }
    }
}