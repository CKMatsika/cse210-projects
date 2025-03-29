using System;
using System.Collections.Generic;

/// <summary>
/// Represents a scripture with a reference and the text divided into words.
/// </summary>
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    /// <summary>
    /// Creates a new Scripture with the given reference and text.
    /// The text is automatically split into Word objects.
    /// </summary>
    /// <param name="reference">The scripture reference.</param>
    /// <param name="text">The full text of the scripture.</param>
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        // Split the text into individual words
        string[] wordArray = text.Split(' ');
        foreach (string wordText in wordArray)
        {
            // Create a new Word object for each word and add it to the list
            _words.Add(new Word(wordText));
        }
    }

    /// <summary>
    /// Checks if all words in the scripture are hidden.
    /// </summary>
    /// <returns>True if all words are hidden, false otherwise.</returns>
    public bool AreAllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    /// <summary>
    /// Hides a random number of words in the scripture that are not already hidden.
    /// </summary>
    /// <param name="numberToHide">The number of words to hide.</param>
    public void HideRandomWords(int numberToHide)
    {
        // Create a list of indices of words that are not hidden
        List<int> visibleWordIndices = new List<int>();
        
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                visibleWordIndices.Add(i);
            }
        }

        // If there are fewer visible words than the number we want to hide,
        // adjust the number to hide
        numberToHide = Math.Min(numberToHide, visibleWordIndices.Count);

        // Hide the specified number of words
        for (int i = 0; i < numberToHide; i++)
        {
            if (visibleWordIndices.Count == 0)
            {
                break;
            }

            // Select a random index from the visible words
            int randomIndex = _random.Next(visibleWordIndices.Count);
            int wordIndex = visibleWordIndices[randomIndex];
            
            // Hide the word and remove its index from the list
            _words[wordIndex].Hide();
            visibleWordIndices.RemoveAt(randomIndex);
        }
    }

    /// <summary>
    /// Gets the complete text of the scripture with hidden words replaced by underscores.
    /// </summary>
    /// <returns>The display text of the complete scripture.</returns>
    public string GetDisplayText()
    {
        string displayText = $"{_reference.GetDisplayText()}\n";
        
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }

        return displayText.Trim();
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 7cd836090ceb342e61fb56712cffe17e677395e4
