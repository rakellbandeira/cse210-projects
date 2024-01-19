using System;

public class PromptGenerator
{

    private List<string> prompts;
    public void PromptList()
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