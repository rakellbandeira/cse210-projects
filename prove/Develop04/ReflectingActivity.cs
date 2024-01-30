using System;

public class ReflectingActivity: Activity
{
    protected List<string> _prompts;
    protected List<string> _questions;

    public ReflectingActivity (string name, string description) : base (name, description)
    {
        _name = name;
        _description = description;

    }

    public string GetRandomPrompt()
    {       
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
            
        };
        
        Random random = new Random();

        int randomIndex = random.Next(0, _prompts.Count);

        string promptPick = _prompts[randomIndex];

        return promptPick;    
        
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("");
    }

    public string GetRandomQuestion()
    {
            _questions = new List<string>
            {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"

            };

            Random random2 = new Random();

            int randomIndex2 = random2.Next(0, _questions.Count);

            string questionPick = _questions[randomIndex2];
            
            return questionPick;
    }
    
    public void DisplayQuestions()
    {
        Console.Write($"> {GetRandomQuestion()}");
        
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
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        DisplayPrompt();
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.Clear();

        while (currentTime < endTime)
        {   
            currentTime = DateTime.Now;  

            DisplayQuestions();
            ShowSpinner(8);
            Console.WriteLine("");
        }

        DisplayEndingMessage();

    }
}