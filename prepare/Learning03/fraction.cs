class Fraction
{
    private int _top;
    private int _bottom;
    public Fraction(int topValue = 1, int bottomValue = 1)
    {
        _top = topValue;
        _bottom = bottomValue;
    }
    public string getFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    public double getDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

    public int getNumerator()
    {
        return _top;
    }
    public int getDenominator()
    {
        return _bottom;
    }
    public void setNumerator(int numerator)
    {
        _top = numerator;
    }
    public void setDenominator(int denominator)
    {
        _bottom = denominator;
    }
}