using System;

class Program
{
    static void Main()
    {
        // Initialize the random number generator
        Random random = new Random();
        
        // Declare the magic number as a random number between 1 and 100
        int magicNumber = random.Next(1, 101); // 1 to 100
        
        // Declare a variable for the user's guess
        int guess = 0;
        
        // Variable to keep track of the number of guesses
        int guessCount = 0;

        // Start a loop for the game
        while (guess != magicNumber)
        {
            // Ask the user for their guess
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            // Increase the guess count
            guessCount++;

            // Check if the guess is correct, too high, or too low
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"You guessed it! It took you {guessCount} guesses.");
            }
        }

        // After the game ends, ask if they want to play again
        Console.Write("Do you want to play again? (yes/no): ");
        string playAgain = Console.ReadLine().ToLower();

        // If yes, restart the game
        while (playAgain == "yes")
        {
            magicNumber = random.Next(1, 101); // Generate a new magic number
            guess = 0; // Reset guess
            guessCount = 0; // Reset guess count

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! It took you {guessCount} guesses.");
                }
            }

            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();
        }

        // End the game
        Console.WriteLine("Thanks for playing!");
    }
}
