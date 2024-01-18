using System;
using System.IO;

public class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();

    List<string> prompts = new List<string> {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

    string randomPrompt = GetRandomPrompt(prompts);


    public T GetRandomPrompt<T>(List<T> prompts)
    {
        Random random = new Random();
        int randomIndex = random.Next(0, prompts.Count);
        return prompts[randomIndex];
    }
    

    public void AddEntry(string prompt, string response)
    {     

        JournalEntry entry = new JournalEntry(prompt, response);

        entries.Add(entry);

        
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }


    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(var entry in entries)
            {
                outputFile.WriteLine(
                    $"@ Date: {entry._date} - Prompt: {_prompText}\n{_entryText}"
                );
            }
        }
    }

    public void LoadFromFile(string filetoOpen)
    {
        entries.Clear();

        string[] lines = System.IO.File.ReadAllLines(filetoOpen);

        foreach (string line in lines)
        {
            string[] parts = line.Split("@");
            Console.WriteLine(parts);

        }
    }
    

}

