using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction x = new Fraction(-1, 12);
        Console.WriteLine(x.getDecimalValue());
        Console.WriteLine(x.getFractionString());

        Fraction y = new Fraction(5);
        Console.WriteLine(y.getDecimalValue());
        Console.WriteLine(y.getFractionString());

        Fraction z = new Fraction();
        Console.WriteLine(z.getDecimalValue());
        Console.WriteLine(z.getFractionString());
    }
}