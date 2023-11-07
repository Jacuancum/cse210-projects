public class Circle : Shape
{
    private double _radius;

    //The variable color is inherit from base color.
    //The radius variable is from Circle.
    public Circle(string color, double radius) : base (color)
    {
        _radius = radius;
    }

    // Override the GetArea() variables to be radius*radius*PI
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}