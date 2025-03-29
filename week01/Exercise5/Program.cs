using System;

class Program
{
    // DisplayWelcome function to display a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // PromptUserName function to ask for the user's name and return it
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // PromptUserNumber function to ask for the user's favorite number and return it
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    // SquareNumber function to return the square of an integer
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // DisplayResult function to display the user's name and the squared number
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, your favorite number squared is {squaredNumber}.");
    }

    // Main function where all the above functions are called
    static void Main()
    {
        // Call DisplayWelcome function to display the welcome message
        DisplayWelcome();

        // Call PromptUserName function and store the result in the variable userName
        string userName = PromptUserName();

        // Call PromptUserNumber function and store the result in the variable userNumber
        int userNumber = PromptUserNumber();

        // Call SquareNumber function to get the square of the user's number
        int squaredNumber = SquareNumber(userNumber);

        // Call DisplayResult function to display the result
        DisplayResult(userName, squaredNumber);
    }
}
