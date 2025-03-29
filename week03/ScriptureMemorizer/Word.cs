using System;

/// <summary>
/// Represents a word in a scripture, which can be shown or hidden.
/// </summary>
public class Word
{
    private string _text;
    private bool _isHidden;

    /// <summary>
    /// Creates a new Word with the given text, initially shown (not hidden).
    /// </summary>
    /// <param name="text">The text of the word.</param>
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    /// <summary>
    /// Hides this word, replacing it with underscores when displayed.
    /// </summary>
    public void Hide()
    {
        _isHidden = true;
    }

    /// <summary>
    /// Shows this word, displaying its actual text.
    /// </summary>
    public void Show()
    {
        _isHidden = false;
    }

    /// <summary>
    /// Checks if the word is currently hidden.
    /// </summary>
    /// <returns>True if the word is hidden, false otherwise.</returns>
    public bool IsHidden()
    {
        return _isHidden;
    }

    /// <summary>
    /// Gets the displayed representation of this word, either the text or underscores if hidden.
    /// </summary>
    /// <returns>The word's text or underscores matching the length of the text if hidden.</returns>
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            // Replace each character with an underscore
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}