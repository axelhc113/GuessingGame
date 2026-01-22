// Name: Axel Cordova
// Course: CIS261
// Lab: Guessing Game

using System;

Random rand = new Random();

Console.WriteLine("Guess the number!");
Console.WriteLine();

while (true)
{
    int limit = PromptForLimit();
    PlayGame(limit);

    Console.Write("Would you like to play again? (y/n): ");
    string? again = Console.ReadLine();

    if (again == null || again.Trim().ToLower() != "y")
        break;

    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("Bye!");

int PromptForLimit()
{
    while (true)
    {
        Console.Write("Enter the limit: ");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int limit) && limit > 1)
            return limit;
    }
}

void PlayGame(int limit)
{
    int secret = rand.Next(1, limit + 1);

    Console.WriteLine($"I'm thinking of a number from 1 to {limit}");
    Console.WriteLine();

    int tries = 0;

    while (true)
    {
        Console.Write("Your guess: ");
        string? guessInput = Console.ReadLine();

        if (!int.TryParse(guessInput, out int guess))
            continue;

        tries++;

        if (guess < secret)
        {
            Console.WriteLine("Too low.");
        }
        else if (guess > secret)
        {
            Console.WriteLine("Too high.");
        }
        else
        {
            Console.WriteLine($"You guessed it in {tries} tries.");
            break;
        }
    }
}
