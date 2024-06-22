class Rectangle : Shape
{
    public double _sideA;
    public double _sideB;
    public Rectangle(string color, double sideA, double sideB)
    {
        _color = color;
        _sideA = sideA;
        _sideB = sideB;
    }
    public override double getArea()
    {
        return _sideA * _sideB;
    }
}