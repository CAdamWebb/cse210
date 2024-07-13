using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.WriteLine("First name:");
        string firstName = Console.ReadLine();
        Console.WriteLine("Last name:");
        string lastName = Console.ReadLine();
        Console.WriteLine($"{lastName}, {firstName} {lastName}.");
    }
}