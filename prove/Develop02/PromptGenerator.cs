using System;

public class PromptGenerator
{
    /*  static void Main()
     {
        List<string> prompts = new List<string> {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        string randomPrompt = GetRandomPrompt(prompts);

    } */

    static T GetRandomPrompt<T>(List<T> prompts)
    {
        Random random = new Random();
        int randomIndex = random.Next(0, prompts.Count);
        return prompts[randomIndex];
    }


   }