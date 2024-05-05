using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 1000);
        
        int guess = 0;
        while (guess != magicNumber)
        {
            Console.Write("Guess: ");
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess > magicNumber)
            {
                Console.WriteLine("Too big!");
            }
            if (guess < magicNumber)
            {
                Console.WriteLine("Too small!");
            }
        }

        Console.WriteLine("You got it!");
    }
}