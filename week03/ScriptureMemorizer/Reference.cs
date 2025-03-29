using System;

/// <summary>
/// Represents a scripture reference, such as "John 3:16" or "Proverbs 3:5-6".
/// </summary>
public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    /// <summary>
    /// Creates a reference with a single verse (e.g., "John 3:16").
    /// </summary>
    /// <param name="book">The book name.</param>
    /// <param name="chapter">The chapter number.</param>
    /// <param name="verse">The verse number.</param>
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse; // Single verse, so end verse is the same as start verse
    }

    /// <summary>
    /// Creates a reference with a verse range (e.g., "Proverbs 3:5-6").
    /// </summary>
    /// <param name="book">The book name.</param>
    /// <param name="chapter">The chapter number.</param>
    /// <param name="startVerse">The starting verse number.</param>
    /// <param name="endVerse">The ending verse number.</param>
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    /// <summary>
    /// Gets a string representation of this reference.
    /// </summary>
    /// <returns>A string like "John 3:16" or "Proverbs 3:5-6".</returns>
    public string GetDisplayText()
    {
        if (_startVerse == _endVerse)
        {
            // Single verse
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            // Verse range
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }
}