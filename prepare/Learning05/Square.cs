using System.Formats.Asn1;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

class Square: Shape
{
    private double _side;

    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}