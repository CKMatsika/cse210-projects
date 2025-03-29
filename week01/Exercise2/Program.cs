using System;

class Program
{
    static void Main()
    {
        // Ask for the grade percentage
        Console.Write("Enter your grade percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());

        // Declare a variable for the letter grade and sign
        string letter = "";
        string sign = "";

        // Determine the letter grade based on the grade percentage
        if (gradePercentage >= 90)
        {
            letter = "A";
            int lastDigit = gradePercentage % 10;
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
            int lastDigit = gradePercentage % 10;
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
            int lastDigit = gradePercentage % 10;
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
            int lastDigit = gradePercentage % 10;
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else
        {
            letter = "F";
        }

        // Check if the user passed the course
        if (gradePercentage >= 70)
        {
            Console.WriteLine($"Your grade is {letter}{sign}. Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine($"Your grade is {letter}. Better luck next time!");
        }
    }
}
