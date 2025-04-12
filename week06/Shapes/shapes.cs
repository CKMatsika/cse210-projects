// Base Shape class
public class Shape
{
    private string _color;

    // Constructor
    public Shape(string color)
    {
        _color = color;
    }

    // Getter and setter for color
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    // Virtual method for GetArea - will be overridden by derived classes
    public virtual double GetArea()
    {
        // Default implementation - should be overridden
        return 0;
    }
}
