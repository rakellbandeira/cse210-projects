using System;

public class Rectangles: Shape
{
    private double _length = 0;
    private double _width = 0;

    public Rectangles(string color, double length, double width): base (color)
    {
        _color = color;
        _length = length;
        _width = width;
    }

    public override GetArea()
    {
        return _length * _width;
    }
}