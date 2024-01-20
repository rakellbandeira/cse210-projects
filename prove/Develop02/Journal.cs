using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<JournalEntry> entries;

    public Journal()
    {
        entries = new List<JournalEntry>();

    }
    
    public void AddEntry(string prompt)
    {     
        Console.WriteLine("Ok, let's write a new page of your journal: ");
        Console.WriteLine($"Here's a prompt for you: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        string date = DateTime.Now.ToShortDateString();

        JournalEntry entry = new JournalEntry(prompt, response, date);     
        

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
                    $"@ Date: {entry._date} - Prompt: {entry._prompText}\n{entry._entryText}"
                );
            }

            Console.Write($"New file {filename} added successfully.");        }
    }



    public void LoadFromFile(string fileToOpen)
    {
        entries.Clear();

        string[] lines = System.IO.File.ReadAllLines(fileToOpen);

        foreach (string line in lines)
        {
            string[] parts = line.Split("@");
            Console.WriteLine(parts);

        }
    }
    

}

