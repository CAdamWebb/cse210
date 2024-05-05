using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        int input = -1;
        while (input != 0)
        {
            Console.Write("Number: ");
            input = int.Parse(Console.ReadLine());
            if (input != 0)
            {
                numbers.Add(input);
            }
            

        }
        int sum = 0;
        int max = 0;
        foreach (int i in numbers)
        {
            Console.Write(i);
            Console.Write(" ");

            sum += i;
            if (i > max)
            {
                max = i;
            }
        }
        Console.WriteLine("\nSum: " + sum);
        Console.WriteLine("max: " + max);
        Console.WriteLine("Average: " + (sum / numbers.Count));
    }
}