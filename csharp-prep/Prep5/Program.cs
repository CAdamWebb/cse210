using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Name: ");
            return Console.ReadLine();
        }

        static int PromptUserNumber()
        {
            Console.Write("Number: ");
            return int.Parse(Console.ReadLine());
        }

        static int SquareNumber(int n)
        {
            return n * n;
        }

        static void DisplayResult(string name, int num)
        {
            Console.WriteLine($"Name: {name}\nSquared number: {num}");
        }

        DisplayWelcome();
        DisplayResult(PromptUserName(), SquareNumber(PromptUserNumber()));
    }
}