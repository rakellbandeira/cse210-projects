using System;

public class JournalEntry
{
    public string _prompText {get; set;}
    public string _entryText {get; set;}
    public string _date {get; set;}

    public JournalEntry(string prompt, string response, string date)
    {
        _prompText = prompt;
        _entryText = response;
        _date = date;
    }

    public string Info()
    {
        string info = $"Date: {_date} Prompt of the Day: {_prompText} Your Response:{_entryText}";
        return info;
    }
}