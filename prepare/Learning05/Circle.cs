class Circle : Shape
{
    public double _radius;
    public Circle(string color, double radius)
    {
        _color = color;
        _radius = radius;
    }
    public override double getArea()
    {
        return _radius * _radius * Math.PI;
    }
}