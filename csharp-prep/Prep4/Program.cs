using System;
using System.Globalization;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int numbElem;

        do{
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out numbElem))
            {
                if (numbElem != 0)
                {
                    numbers.Add(numbElem);
                }
                else
                {
                    Console.WriteLine("End of list.");
                }
            
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }


        } while (numbElem != 0);

               
        /*
        Console.Write("The list:");

        foreach (int number in numbers)
        {
            Console.Write(number);
        }
        */

        

        int sum = 0;

        foreach (int number in numbers)
        {
            sum+= number;
            //Console.WriteLine($"The new sum: {sum}");
        }

        //Console.Write(numbers.Count);
        Console.WriteLine($"The sum is: {sum}.");

        float average = sum/ numbers.Count;
        Console.WriteLine($"The average is: {average}.");


        int maxNumber = numbers[0];
        foreach (int number in numbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }

        Console.WriteLine($"The largest number is: {maxNumber}.");


    }
}