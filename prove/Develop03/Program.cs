using System;

class Program
{
    static void Main(string[] args)
    {
        string[] scriptureArray = {
            "For God so loved the world, that He gave his only Son.",
            "Therefore, go. And I said unto my father: I will go and do",
        };

        string[] referenceArray = {
            "John 3:16",
            "1 Nephi 3:6-7",
        };

        Random random = new Random();
        int randomIndex = random.Next(0, scriptureArray.Length);

        string randomScriptureText = scriptureArray[randomIndex];
        string randomReference = referenceArray[randomIndex];



        Reference reference = new Reference (randomReference);
        Scripture scripture = new Scripture(reference, randomScriptureText);

        Console.WriteLine(scripture.GetDisplayScrip());
        string userInput = Console.ReadLine();

         while (!scripture.IsCompletelyHidden())
            {
                if (userInput.ToLower() == "quit")
                {
                    Console.WriteLine("You quit the program.");
                    Environment.Exit(0);
                }
                else if (userInput.ToLower() != "quit")
                {           
                    scripture.HideRandomWords(3);
                    Console.Clear();
                    Console.WriteLine(scripture.GetDisplayScrip());
                    userInput = Console.ReadLine();
                }

            Console.WriteLine("You are done!");       
            

        }
    }
}