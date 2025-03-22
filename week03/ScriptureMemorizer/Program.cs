using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Create a library of scriptures
        List<Scripture> scriptureLibrary = CreateScriptureLibrary();
        
        // Choose a random scripture to memorize
        Random random = new Random();
        Scripture scripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];
        
        string input = "";
        
        // Continue until all words are hidden or the user quits
        while (input.ToLower() != "quit" && !scripture.AreAllWordsHidden())
        {
            // Clear the console and display the scripture
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            
            // Get user input
            input = Console.ReadLine();
            
            // If the user didn't quit, hide more words
            if (input.ToLower() != "quit")
            {
                // Hide 3 random words each time
                scripture.HideRandomWords(3);
            }
        }

        // Show the final state of the scripture with all words hidden (if the user didn't quit)
        if (input.ToLower() != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Great job! You've memorized the entire scripture.");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
    
    /// <summary>
    /// Creates a library of different scriptures to memorize.
    /// </summary>
    /// <returns>A list of Scripture objects.</returns>
    static List<Scripture> CreateScriptureLibrary()
    {
        List<Scripture> library = new List<Scripture>();
        
        // Add a few scriptures to the library
        
        // John 3:16
        Reference ref1 = new Reference("John", 3, 16);
        Scripture scripture1 = new Scripture(ref1, 
            "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        library.Add(scripture1);
        
        // Proverbs 3:5-6
        Reference ref2 = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture2 = new Scripture(ref2, 
            "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");
        library.Add(scripture2);
        
        // Philippians 4:13
        Reference ref3 = new Reference("Philippians", 4, 13);
        Scripture scripture3 = new Scripture(ref3, 
            "I can do all things through Christ who strengthens me.");
        library.Add(scripture3);
        
        // Add more scriptures here if desired
        
        return library;
    }
    
    /* 
    * EXCEEDING REQUIREMENTS:
    * 1. Added a library of multiple scriptures rather than just a single one
    * 2. Randomly selects a scripture from the library for the user to memorize
    * 3. Uses a smarter algorithm that only hides words that are still visible
    *    (doesn't try to hide already hidden words)
    * 4. Shows an encouraging message when the user completes the memorization
    * 5. Shows how many words are still visible and how many are hidden during each step
    *    to help track progress
    */
}
