public class Rectangle : Shape
{
    private double _length;
    private double _width;

    //The variable color is inherit from base color.
    //The length and width variable is from Rectangle.
    public Rectangle(string color, double length, double width) : base (color)
    {
        _length = length;
        _width = width;
    }

    // Override the GetArea() variables to be length*width
    public override double GetArea()
    {
        return _length * _width;
    }
}