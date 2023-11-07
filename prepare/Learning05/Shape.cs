using System.Formats.Asn1;

public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    // Because it does not make sense to define a default body for this method in the
    // base class, rather than make a "virtual" function here like this:
    //
    // public virtual double GetArea()
    // {
    //     return 0;
    // }
    public abstract double GetArea();
    
}