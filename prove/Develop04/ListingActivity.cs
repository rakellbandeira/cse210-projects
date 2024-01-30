using System;


public class ListingActivity: Activity
{
    protected int _count;
    protected List<string> _prompts;

    public ListingActivity (string name, string description) : base (name, description)
    {
        _name = name;
        _description = description;
    }

    public void GetRandomPrompt()
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
            
        };
        
        Random random = new Random();

        int randomIndex = random.Next(0, _prompts.Count);

        string promptPick = _prompts[randomIndex];

        Console.WriteLine("");
        Console.WriteLine($"--- {promptPick} ---");
        Console.WriteLine("");

        /* return promptPick;  */  
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();

        Console.Write("> ");
        string listItem = Console.ReadLine();
        Console.WriteLine("");

        userList.Add(listItem);

        return userList;
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("");
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.Write("Get ready...");
        ShowSpinner(4);
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        /* string startTimeTime = startTime.ToString("HH:mm:ss"); */
        DateTime endTime = startTime.AddSeconds(_duration);
        /* string endTimeTime = endTime.ToString("HH:mm:ss"); */
        DateTime currentTime = DateTime.Now;
        /* string currentTimeTime = currentTime.ToString("HH:mm:ss"); */

        Console.WriteLine("");
        Console.WriteLine("List as many responses you can to the following prompt: ");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.Clear();

        while (currentTime < endTime)
        {
            currentTime = DateTime.Now;  
            GetListFromUser();
        }

        DisplayEndingMessage();

    }

    
}