class Program
{
    static void Main(string[] args)
    {
        // Test individual shape classes
        Console.WriteLine("Testing individual shape classes:");
        
        // Create a square and test its methods
        Square square = new Square("Red", 5);
        Console.WriteLine($"Square - Color: {square.GetColor()}, Area: {square.GetArea()}");
        
        // Create a rectangle and test its methods
        Rectangle rectangle = new Rectangle("Blue", 4, 6);
        Console.WriteLine($"Rectangle - Color: {rectangle.GetColor()}, Area: {rectangle.GetArea()}");
        
        // Create a circle and test its methods
        Circle circle = new Circle("Green", 3);
        Console.WriteLine($"Circle - Color: {circle.GetColor()}, Area: {circle.GetArea()}");
        
        Console.WriteLine("\nDemonstrating polymorphism with a list of shapes:");
        
        // Create a list of shapes to demonstrate polymorphism
        List<Shape> shapes = new List<Shape>();
        
        // Add different shapes to the list
        shapes.Add(new Square("Yellow", 7));
        shapes.Add(new Rectangle("Purple", 8, 3));
        shapes.Add(new Circle("Orange", 4));
        
        // Iterate through the list and display each shape's properties
        // This demonstrates polymorphism - the same method call behaves differently
        // depending on the actual type of the object
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape - Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}
