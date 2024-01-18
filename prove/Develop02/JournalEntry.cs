using System;

public class JournalEntry(prompt, response)
{
    string _prompText = prompt;
    string _entryText = response;
    string _date = DateTime.Now.ToShortDateString();
}