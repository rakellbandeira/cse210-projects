using System;
using System.Collections.Generic;
/*
        variables:
        prompts: List<string>
        
        methods:
        PromptGenerator(): void
        GetRandomPrompt(): string
        This last function gets a random number taken from the range of the
        list's length and used as an index to access to correspondent
        element of the list.

    */


class PromptGenerator
{

    private List<string> prompts;
    public PromptGenerator()
    {
        prompts = new List<string> {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };      

    }
    
      
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, prompts.Count);

        string prompt = prompts[randomIndex];

        return prompt;
    }
    
    


}