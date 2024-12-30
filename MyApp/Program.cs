using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Guess the Number game!");

        // Generate a random number between 1 and 100
        Random random = new Random();
        int numberToGuess = random.Next(1, 101);
        int userGuess = 0;
        int numberOfTries = 0;

        // Game loop
        while (userGuess != numberToGuess)
        {
            Console.WriteLine("Please enter your guess (between 1 and 100): ");
            string userInput = Console.ReadLine();

            // Check if input is a valid number
            if (int.TryParse(userInput, out userGuess))
            {
                numberOfTries++;
                if (userGuess > numberToGuess)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else if (userGuess < numberToGuess)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the number {numberToGuess} in {numberOfTries} tries.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
        }
    }
}