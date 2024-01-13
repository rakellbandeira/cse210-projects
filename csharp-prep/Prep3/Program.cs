using System;

class Program
{
    static void Main(string[] args)
    {
        // Getting a random Number
        Random random = new Random();
        int randomNumber = random.Next(1, 99);
        Console.WriteLine($"The random number: {randomNumber}");

        int userGuess;

        do
        {
            Console.Write("Enter your guess (Up to 2 dig): ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out userGuess))
            {
                if (userGuess == randomNumber)
                {
                    Console.Write("You guessed right!");
                }
                else if (userGuess < randomNumber)
                {
                    Console.WriteLine("Try higher!");
                }
                else
                {
                    Console.WriteLine("Try lower!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

        } while (userGuess != randomNumber);
    }
}




