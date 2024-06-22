class Square : Shape
{
    public double _side;
    public Square(string color, double side)
    {
        _color = color;
        _side = side;
    }
    public override double getArea()
    {
        return _side * _side;
    }
}