using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

class Shape
{
    protected string _color;
    public string GetColor()
    {
        return _color;
    }
    protected void SetColor(string color)
    {
        _color = color;
    }
    public Shape(string color)
    {
        _color = color;
    }
    public virtual double GetArea()
    {
        //virtual
        return 1;
    }
}